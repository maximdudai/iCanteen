using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.Reserve;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Menu.MenuList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSI_DA_PL_B.views.Clients.Both.ListClients;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSI_DA_PL_B.views.Reserve.Make
{
    public partial class MakeReserve : Form
    {
        private Manager manager { get; set; }
        private int nif;
        private string typeClient;
        private List<Dish> availableDishes = new List<Dish>();
        private List<Extra> availableExtras = new List<Extra>();
        private decimal totalReservationCost = 0.00m;
        public MakeReserve()
        {
            InitializeComponent();
        }

        public MakeReserve(int nif, string typeClient, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
            this.typeClient = typeClient;
            LoadClient();
        }     

        private void LoadClient()
        {
            try
            {
                using (var db = new Cantina())
                {
                    if (this.typeClient == "Estudante")
                    {
                        var nifStudentReceived = db.User
                        .OfType<Student>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                        if (nifStudentReceived != null)
                        {
                            typeClientLabel.Text = "Estudante";
                            nifLabel.Text = nifStudentReceived.Nif.ToString();
                            balanceLabel.Text = nifStudentReceived.Balance.ToString();
                        }
                    }

                    if (this.typeClient == "Professor")
                    {
                        var nifTeacherReceived = db.User
                        .OfType<Teacher>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                        if (nifTeacherReceived != null)
                        {
                            typeClientLabel.Text = "Professor";
                            nifLabel.Text = nifTeacherReceived.Nif.ToString();
                            balanceLabel.Text = nifTeacherReceived.Balance.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void MakeReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }

        private void reserveDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateAndLoadMenu();
        }

        private void lunchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lunchRadioButton.Checked)
                ValidateAndLoadMenu();
        }

        private void dinnerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dinnerRadioButton.Checked)
                ValidateAndLoadMenu();
        }

        private void ValidateAndLoadMenu()
        {
            if (reserveDatePicker.Value != null && (lunchRadioButton.Checked || dinnerRadioButton.Checked))
            {
                LoadMenu();
            }
        }

        private void LoadMenu()
        {
            try
            {
                DateTime selectedDate = reserveDatePicker.Value.Date;
                int mealType = lunchRadioButton.Checked ? 0 : (dinnerRadioButton.Checked ? 1 : -1);

                if (mealType == -1)
                    return;

                using (var db = new Cantina())
                {
                    var menu = db.MenuCantina
                        .Include(m => m.Dishes)
                        .Include(m => m.Extras)
                        .FirstOrDefault(m => DbFunctions.TruncateTime(m.Data) == selectedDate && m.TipoRefeicao == mealType);

                    if (menu == null)
                    {
                        MessageBox.Show("No menu available for the selected date and meal type.");
                        menuListBox.Items.Clear();
                        totalReservationCost = 0.00m;
                        totalReserveLabel.Text = totalReservationCost.ToString("0.00");
                        return;
                    }

                    menuListBox.Items.Clear();
                    totalReservationCost = GetClientPrice(menu.PrecoEstudante, menu.PrecoProfessor); // Set total cost

                    foreach (var dish in menu.Dishes)
                    {
                        menuListBox.Items.Add($"Dish: {dish.Description}");
                    }

                    foreach (var extra in menu.Extras)
                    {
                        menuListBox.Items.Add($"Extra: {extra.Descricao}");
                    }

                    totalReserveLabel.Text = totalReservationCost.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu: {ex.Message}", "Error");
            }
        }

        private decimal GetClientPrice(decimal precoEstudante, decimal precoProfessor)
        {
            if (this.typeClient == "Estudante")
            {
                return precoEstudante;
            }
            if (this.typeClient == "Professor")
            {
                return precoProfessor;
            }
            else
            {
                throw new Exception("Not client found"); 
            }
        }

        private void makeReserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Cantina())
                {
                    if (typeClient == "Estudante")
                    {
                        var student = db.User.OfType<Student>().FirstOrDefault(u => u.Nif == nif);
                        if (student != null)
                        {
                            student.Balance -= totalReservationCost;
                        }
                    }
                    else if (typeClient == "Professor")
                    {
                        var teacher = db.User.OfType<Teacher>().FirstOrDefault(u => u.Nif == nif);
                        if (teacher != null)
                        {
                            teacher.Balance -= totalReservationCost;
                        }
                    }

                    db.SaveChanges();
                }

                GenerateReceipt();
                MessageBox.Show("Reservation successfully made!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error making reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReceipt()
        {
            try
            {
                string receiptContent = $"Detalhes da Reserva:\n";
                receiptContent += $"Cliente: {typeClientLabel.Text}\n";
                receiptContent += $"Reservation Date: {reserveDatePicker.Value.ToShortDateString()}\n";
                receiptContent += $"Reservation Time: {(lunchRadioButton.Checked ? "Lunch" : "Dinner")}\n";
                receiptContent += $"Items:\n";

                foreach (var item in menuListBox.Items)
                {
                    receiptContent += $"{item}\n";
                }

                receiptContent += $"Total: {totalReservationCost.ToString("0.00")}€";

                string fileName = $"Reservation_{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt";
                string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
                System.IO.File.WriteAllText(filePath, receiptContent);

                MessageBox.Show($"Receipt saved to:\n{filePath}", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***TODO***
        - Para cada entidade deverá ser efetuado o CRUD, e apresentada uma lista dos registos;
        - Na realização de uma reserva deverá:
            - ser escolhido cliente [alterar]
                    - tabela na base de dados com todos os clientes que foram almoçar/jantar pelo menos uma vez a cantina, se ele não estiver na base de dados, o funcionário pode ou não adiciona-lo.
            - ser escolhido o prato e os extras disponíveis no menu selecionado
            - Ao preço do Menu de cada Cliente deverá ser somado o preço de cada Extra escolhido
            - apenas poderá efetuar uma reserva de um Prato por dia e de três Extra no máximo
            - não poderá escolher pratos ou extras sem quantidade disponível
        No fim:
            - caso a reserva seja feita no período já considerado de multa, a respetiva multa deverá ser registada
            - para cada Reserva feita deverá ser decrementada a quantidade disponível e o valor do saldo do Cliente
            - deverá ser emitido um talão gravado num ficheiro de texto com informação do cliente e do menu (dia/hora, prato e extras)  [pode-se colocar saldo cativo]
        **********/

        private void MakeReserve_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }
    }
}
