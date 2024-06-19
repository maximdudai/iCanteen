using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.Reserve;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;

using System.Data.Entity;

using System.Linq;

using System.Windows.Forms;


namespace PSI_DA_PL_B.views.Reserve.Make
{
    public partial class MakeReserve : Form
    {
        private Manager manager { get; set; }
     
        public int nif { get; set; }
        public string clientType { get; set; }

        private Week weekData { get; }
        private int currentWeek { get; set; }
        private int CURRENT_WEEK_VIEW { get; set; }
        private int NEXT_WEEK = 2;
        private int PREVIOUS_WEEK = 1;

        private int selectedMenuId { get; set; }

        List<FormatMenu> availableMenus { get; set; }

        List<models.Menu.Dish> dishes { get; set; }
        List<models.Menu.Extra> extras { get; set; }


        public MakeReserve(int nif, string type, Manager manager)
        {
            InitializeComponent();

            this.availableMenus = new List<FormatMenu>();
            this.extras = new List<models.Menu.Extra>();
            this.dishes = new List<models.Menu.Dish>();

            this.manager = manager;
            this.nif = nif;
            this.clientType = type;


            this.weekData = new Week();
            this.CURRENT_WEEK_VIEW = this.weekData.GetCurrentYearWeek();
            this.GetMenuCurrentWeek();

            this.UpdateUI(nif, type);
            this.LoadMenus(this.CURRENT_WEEK_VIEW);
        }
        
        private void UpdateUI(int nif, string type)
        {
            using (var db = new Cantina())
            {

                if (this.clientType == "Estudante")
                {
                    var user = db.User
                        .OfType<Student>()
                        .Where(st => st.Nif == nif)
                        .Select(st => new
                        {
                            st.Balance
                        })
                        .FirstOrDefault();

                    this.balanceLabel.Text = user.Balance.ToString();
                }
                else
                {
                    var user = db.User
                        .OfType<Teacher>()
                        .Include(u => u.Balance)
                        .Where(u => u.Nif == nif)
                        .FirstOrDefault();

                    this.balanceLabel.Text = user.Balance.ToString();

                }

                this.typeClientLabel.Text = type;
                this.nifLabel.Text = this.nif.ToString();
            }
        }

        public void LoadMenus(int w_id)
        {
            using (var db = new Cantina())
            {
                var menus = db.MenuCantina.Where(m => m.Week == w_id).ToList();

                if (menus.Count == 0)
                {
                    this.menuListBox.ClearSelected();
                    this.menuListBox.SelectedIndex = -1;

                    if (this.availableMenus.Count > 0)
                    {
                        this.availableMenus.Clear();
                        this.dishes.Clear();
                        this.extras.Clear();
                    }
                }
                else
                {
                    // Clear the availableMenus list before adding new items
                    this.availableMenus.Clear();

                    foreach (var item in menus)
                    {
                        // Make sure to use the correct constructor parameters
                        FormatMenu menu = new FormatMenu
                        {
                            Id = item.Id,  // Ensure Id is set correctly
                            Data = item.Data,
                            TipoRefeicao = item.TipoRefeicao,
                            Quantidade = item.Quantidade,
                            PrecoEstudante = item.PrecoEstudante,
                            PrecoProfessor = item.PrecoProfessor,
                            Week = item.Week
                        };

                        this.availableMenus.Add(menu);
                    }
                }

                // Update the list of menus
                this.UpdateListMenus();
            }
        }

        public void UpdateListMenus()
        {
            this.menuListBox.DataSource = null;
            this.menuListBox.DataSource = this.availableMenus;

            this.includedDish.DataSource = null;
            this.includedDish.DataSource = this.dishes;

            this.includedExtra.DataSource = null;
            this.includedExtra.DataSource = this.extras;
        }


        private void MakeReserve_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }

        private void menuNextWeek_Click(object sender, EventArgs e)
        {
            this.GetMenuCurrentWeek(this.NEXT_WEEK);
        }

        private void menuPrevWeek_Click(object sender, EventArgs e)
        {
            this.GetMenuCurrentWeek(this.PREVIOUS_WEEK);
        }

        private void GetMenuCurrentWeek(int operation = 0)
        {

            // operation 0 = no operation
            // operation 1 = previous week
            // operation 2 = next week

            int week = weekData.GetCurrentYearWeek();

            if (operation == this.PREVIOUS_WEEK)
            {
                // if the current week is the first week of the year, set the week to the last week of the year
                if (this.currentWeek <= this.weekData.GetMinWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.weekData.GetMaxWeeksOfYear();
                }
                else
                {
                    this.CURRENT_WEEK_VIEW--;
                }

                week = this.CURRENT_WEEK_VIEW;
            }
            else if (operation == this.NEXT_WEEK)
            {
                // if the current week is the last week of the year, set the week to the first week of the year
                if (this.currentWeek >= this.weekData.GetMaxWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.weekData.GetMinWeeksOfYear();
                }
                else
                {
                    this.CURRENT_WEEK_VIEW++;
                }

                week = this.CURRENT_WEEK_VIEW;
            }

            this.currentWeek = CURRENT_WEEK_VIEW;

            LoadMenus(week);

            this.UpdateWeekUI();
        }
        private void UpdateWeekUI()
        {
            this.currentWeekLabel.Text = this.currentWeek.ToString();
        }

        private void menuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMenu = (FormatMenu)this.menuListBox.SelectedItem;

            if (selectedMenu == null)
            {
                this.includedDish.DataSource = null;
                this.includedExtra.DataSource = null;
                return;
            }

            using (var db = new Cantina())
            {
                var menu = db.MenuCantina.FirstOrDefault(m => m.Id == selectedMenu.Id);

                if (menu != null)
                {
                    this.selectedMenuId = menu.Id;
                    this.GetAllDishByMenuId(this.selectedMenuId);
                    this.GetAllExtraByMenuId(this.selectedMenuId);
                }
            }

        }

        private void GetAllExtraByMenuId(int menuId)
        {
            List<MenuCanteenExtra> menuExtras = new List<MenuCanteenExtra>();
            using (var db = new Cantina())
            {
                menuExtras = db.MenuCanteenExtras.Where(e => e.MenuCanteenId == menuId).ToList();
            }

            this.extras.Clear();
            foreach (var item in menuExtras)
            {
                this.GetExtraDataById(item.ExtraId);
            }
        }


        private void GetAllDishByMenuId(int menuId)
        {
            List<MenuCanteenDish> menuDishes = new List<MenuCanteenDish>();
            using (var db = new Cantina())
            {
                menuDishes = db.MenuCanteenDishes.Where(d => d.MenuCanteenId == menuId).ToList();
            }

            this.dishes.Clear();
            foreach (var item in menuDishes)
            {
                this.GetDishDataById(item.DishId);
            }
        }


        // get dish information by id

        private void GetDishDataById(int id)
        {
            using (var db = new Cantina())
            {
                var dish = db.Dish.FirstOrDefault(d => d.itemId == id);
                if (dish != null)
                {
                    models.Menu.Dish dishRow = new models.Menu.Dish(dish.Description, dish.Type, dish.Active);
                    this.dishes.Add(dishRow);
                }
            }

            this.UpdateDishList();
        }


        // get extra information by id
        private void GetExtraDataById(int id)
        {
            using (var db = new Cantina())
            {
                var extra = db.Extra.FirstOrDefault(e => e.itemId == id);
                if (extra != null)
                {
                    models.Menu.Extra extraRow = new models.Menu.Extra(extra.Descricao, extra.Preco, extra.Ativo);
                    this.extras.Add(extraRow);
                }
            }
            this.UpdateExtraList();
        }

        private void UpdateDishList()
        {
            this.includedDish.DataSource = null;
            this.includedDish.DataSource = this.dishes;
        }

        private void UpdateExtraList()
        {
            this.includedExtra.DataSource = null;
            this.includedExtra.DataSource = this.extras;
        }

        private void makeReseveButton_Click(object sender, EventArgs e)
        {
            var selectedMenu = (FormatMenu)this.menuListBox.SelectedItem;

            if (selectedMenu == null)
            {
                MessageBox.Show("Please select a menu to reserve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user has enough balance to make the reservation
            decimal price = this.clientType == "Estudante" ? selectedMenu.PrecoEstudante : selectedMenu.PrecoProfessor;

            if (!VerifyClientBalance(price))
            {
                return;
            }

            // Check if the user has already made a reservation for the selected menu

            if (CheckIfUserHasReservation(selectedMenu.Id))
            {
                MessageBox.Show("You have already made a reservation for this menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MakeReservation(selectedMenu.Id);
        }

        private void MakeReservation(int menuId)
        {
            using (var db = new Cantina())
            {
                var menu = db.MenuCantina.FirstOrDefault(m => m.Id == menuId);

                if (menu != null)
                {
                    ReserveCanteen reservation = new ReserveCanteen(this.nif, null, menu.Id);

                    db.ReservaCantina.Add(reservation);
                    db.SaveChanges();

                    MessageBox.Show("Reservation made successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.manager.MainMenuUI();
                }
            }
        }

        private bool CheckIfUserHasReservation(int menuId)
        {
            using (var db = new Cantina())
            {
                var reservation = db.ReservaCantina
                    .Where(r => r.clientNif == this.nif && r.menuId == menuId)
                    .FirstOrDefault();

                if (reservation != null)
                {
                    return true;
                }
            }

            return false;
        }

        private bool VerifyClientBalance(decimal price)
        {
            if (this.clientType == "Estudante")
            {
                using (var db = new Cantina())
                {
                    var user = db.User
                        .OfType<Student>()
                        .Where(st => st.Nif == this.nif)
                        .Select(st => new
                        {
                            st.Balance
                        })
                        .FirstOrDefault();

                    if (user.Balance < price)
                    {
                        MessageBox.Show("You don't have enough balance to make this reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                using (var db = new Cantina())
                {
                    var user = db.User
                        .OfType<Teacher>()
                        .Where(u => u.Nif == this.nif)
                        .Select(u => new
                        {
                            u.Balance
                        })
                        .FirstOrDefault();

                    if (user.Balance < price)
                    {
                        MessageBox.Show("You don't have enough balance to make this reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private class FormatMenu
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public int TipoRefeicao { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoEstudante { get; set; }
            public decimal PrecoProfessor { get; set; }
            public int Week { get; set; }

            public string Type { get; set; }

            public FormatMenu()
            {
            }

            public FormatMenu(int id, DateTime data, int tipoRefeicao, int quantidade, decimal precoEstudante, decimal precoProfessor, int week, string type)
            {
                Id = id;
                Data = data;
                TipoRefeicao = tipoRefeicao;
                Quantidade = quantidade;
                PrecoEstudante = precoEstudante;
                PrecoProfessor = precoProfessor;
                Week = week;
                Type = type;
            }

            public override string ToString()
            {
                string type = TipoRefeicao == 0 ? "Almoço" : "Jantar";

                if (Type == "Estudante")
                {
                    return $"{Data.ToString("dd-MM-yyyy")} - {type} - Stock: {Quantidade} - {PrecoEstudante}€";
                }
                else
                {
                    return $"{Data.ToString("dd-MM-yyyy")} - {type} - Stock: {Quantidade} - {PrecoProfessor}€";
                }
            }
        }
    }
}
