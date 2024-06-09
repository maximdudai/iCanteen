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
using PSI_DA_PL_B.views.Menu.Ticket.Edit;

namespace PSI_DA_PL_B.views.Menu.TicketMenu
{
    public partial class TicketMenu : Form
    {
        private List<models.Menu.Ticket> tickets { get; set; }
        private int time { get; set; }
        private double value { get; set; }
        public TicketMenu()
        {
            InitializeComponent();

            this.tickets = new List<models.Menu.Ticket>();
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

                    var newTicket = new models.Menu.Ticket(this.time, this.value);
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

        private void editTicket_Click(object sender, EventArgs e)
        {
            var selectedTicket = this.ticketList.SelectedItem as models.Menu.Ticket;

            if (selectedTicket == null)
            {
                Error.Err("Please select a ticket to edit.");
                return;
            }


            EditTicket editTicket = new EditTicket(selectedTicket.Id, selectedTicket.hours, selectedTicket.value);
            editTicket.FormClosing += this.EditTicket_Closing;

            editTicket.ShowDialog();

        }
        private void EditTicket_Closing(object sender, FormClosingEventArgs e)
        {
            this.UpdateTicketList();
        }

        private void removeTicket_Click(object sender, EventArgs e)
        {
            var selectedTicket = this.ticketList.SelectedItem as models.Menu.Ticket;

            if (selectedTicket == null)
            {
                Error.Err("Please select an ticket to remove!");
                return;
            }

            using (var db = new Cantina())
            {
                var removeTicket = db.Ticket.Find(selectedTicket.Id);

                if(removeTicket != null)
                {
                    db.Ticket.Remove(removeTicket);
                    db.SaveChanges();
                }
            };

            this.UpdateTicketList();
        }
    }
}
