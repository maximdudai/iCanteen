using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;

namespace PSI_DA_PL_B.views.Menu.Ticket.Edit
{
    public partial class EditTicket : Form
    {
        private int ticketId { get; set; }
        private int ticketTime { get; set; }
        private double ticketValue { get; set; }
        public EditTicket()
        {
            InitializeComponent();
        }

        public EditTicket(int id, int hours, double value) : this()
        {
            this.ticketId = id;
            this.ticketTime = hours;
            this.ticketValue = value;

            this.UpdateEditUI();
        }

        private void UpdateEditUI()
        {
            this.currentTicketId.Text = $"Ticket {this.ticketId}";
            this.currentTicketTime.Text = $"Current Time: {this.ticketTime}h";
            this.currentTicketValue.Text = $"Current Value: {this.ticketValue}€";
        }

        private void editTicketButton_Click(object sender, EventArgs e)
        {
            this.ticketTime = int.Parse(this.newTicketTime.Text);
            this.ticketValue = double.Parse(this.newTicketValue.Text);

            using(var db = new Cantina())
            {
                // verify in database if there is already an ticket with specified hour
                var ticketExists = db.Ticket
                    .Where(ticket => ticket.hours == this.ticketTime)
                    .Select(ticket => new
                    {
                        ticket.hours
                    })
                    .FirstOrDefault();

                //if there is no
                if (ticketExists == null)
                {
                    var newTicket = db.Ticket.Find(this.ticketId);

                    if (newTicket != null)
                    {
                        newTicket.hours = this.ticketTime;
                        newTicket.value = this.ticketValue;
                    }

                    db.SaveChanges();
                } 
                else // if there is
                {
                    Error.Err("An ticket with specified time already exists!");
                    return;
                }
            };

            this.Close();
        }
    }
}
