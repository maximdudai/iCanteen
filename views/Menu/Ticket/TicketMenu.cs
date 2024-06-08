using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;

namespace PSI_DA_PL_B.views.Menu.TicketMenu
{
    public partial class TicketMenu : Form
    {
        private List<Ticket> tickets { get; set; }
        private int time { get; set; }
        private double value { get; set; }
        public TicketMenu()
        {
            InitializeComponent();

            this.tickets = new List<Ticket>();
            this.UpdateTicketList();

        }
        private void createTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(this.ticketTime.Text, out int parsedTime))
                {
                    Error.Err("Please enter a valid integer for the ticket time.");
                    return;
                }

                if (!double.TryParse(this.ticketValue.Text, out double parsedValue))
                {
                    Error.Err("Please enter a valid number for the ticket value.");
                    return;
                }

                this.time = parsedTime;
                this.value = parsedValue;

                if (this.time < (int)this.ticketTime.Minimum || this.time > (int)this.ticketTime.Maximum)
                {
                    Error.Err("Ticket hour must be a number between 1 and 10.");
                    return;
                }

                if (this.value < (double)this.ticketValue.Minimum || this.value > (double)this.ticketValue.Maximum)
                {
                    Error.Err("Ticket value must be a number between 0.1 and 10.");
                    return;
                }

                using (var db = new Cantina())
                {
                    // Check if ticket already exists
                    var checkTicket = db.Ticket
                        .Where(ticket => ticket.hours == this.time)
                        .Select(ticket => new { ticket.hours })
                        .FirstOrDefault();

                    if (checkTicket != null)
                    {
                        Error.Err("Ticket with specified time already exists!");
                        return;
                    }

                    var newTicket = new Ticket(this.time, this.value);
                    db.Ticket.Add(newTicket);
                    db.SaveChanges();
                    this.UpdateTicketList();
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                Error.Err("There was a validation error. Please check the input values.");
            }
            catch (Exception ex)
            {
                Error.Err($"An error occurred: {ex.Message}");
            }
        }


        private void UpdateTicketList()
        {
            using (var db = new Cantina())
            {
                this.tickets = db.Ticket.ToList();
            }
         
            this.ticketList.DataSource = null;
            this.ticketList.DataSource = this.tickets;
        }
    }
}
