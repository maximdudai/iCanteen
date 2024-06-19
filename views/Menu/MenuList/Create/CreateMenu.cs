using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;

namespace PSI_DA_PL_B.views.Menu.MenuList.Create
{
    public partial class CreateMenu : Form
    {
        Manager manager { get; set;}
        DateTime date { get; set; }
        private int menuStock { get; set; } = 1;

        private decimal priceStudent { get; set; }
        private decimal priceTeacher { get; set; }

        // List of available extras and dishes loaded from the database
        List<models.Menu.Extra> AvailableExtra { get; set; }
        List<models.Menu.Dish> AvailableDish { get; set; }

        // List of extras and dishes that will be added to the menu
        List<models.Menu.Extra> SelectedExtra { get; set; }
        List<models.Menu.Dish> SelectedDish { get; set; }

        // Menu limit of extras and dishes
        private int maxExtras { get; set; } = 3;
        private int maxDishes { get; set; } = 1;

        // Total price of the menu
        private decimal totalPrice { get; set; }

        private int menuType { get; set; }

        int Week { get; set; }
        Week weekData { get; set; }

        public CreateMenu(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            // List of available extras and dishes loaded from the database
            AvailableExtra = new List<models.Menu.Extra>();
            AvailableDish = new List<models.Menu.Dish>();

            // List of extras and dishes that will be added to the menu
            SelectedExtra = new List<models.Menu.Extra>();
            SelectedDish = new List<models.Menu.Dish>();

            this.date = DateTime.Now;
            this.menuDefinedDate.Text = this.date.ToString("dd-MM-yyyy");

            this.weekData = new Week();
            this.Week = weekData.GetCurrentYearWeek();

            this.LoadDataFromDatabase();
        }

        private void CreateMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ShowMenuListUI();
        }

        private void createMenuList_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.SelectedDish.Count == 0)
                {
                    Error.Warning("You must select at least 1 dish to create a menu");
                    return;
                }

                if(this.menuTypeAlmoco.Checked == false && this.menuTypeJantar.Checked == false)
                {
                    Error.Warning("You must select a menu type to create a menu");
                    return;
                }

                using (var db = new Cantina())
                {
                    // Create a new menu
                    MenuCanteen menu = new MenuCanteen
                    {
                        Data = this.date.Date,
                        TipoRefeicao = 1,
                        Quantidade = this.menuStock,
                        PrecoEstudante = priceStudent,
                        PrecoProfessor = priceTeacher,
                        Week = this.weekData.GetWeekFromDay(this.date)
                    };

                    // Add the new menu to the context and save it to generate the ID
                    db.MenuCantina.Add(menu);
                    db.SaveChanges();

                    // Insert records into the join tables
                    foreach (var dish in SelectedDish)
                    {
                        var existingDish = db.Dish.FirstOrDefault(d => d.itemId == dish.itemId);
                        if (existingDish != null)
                        {
                            var menuCanteenDish = new MenuCanteenDish
                            {
                                MenuCanteenId = menu.Id,
                                DishId = existingDish.itemId
                            };
                            db.MenuCanteenDishes.Add(menuCanteenDish);
                        }
                    }

                    foreach (var extra in SelectedExtra)
                    {
                        var existingExtra = db.Extra.FirstOrDefault(ex => ex.itemId == extra.itemId);
                        if (existingExtra != null)
                        {
                            var menuCanteenExtra = new MenuCanteenExtra
                            {
                                MenuCanteenId = menu.Id,
                                ExtraId = existingExtra.itemId
                            };
                            db.MenuCanteenExtras.Add(menuCanteenExtra);
                        }
                    }

                    // Save changes to the database
                    db.SaveChanges();
                }
                this.manager.ShowMenuListUI();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        private void LoadDataFromDatabase()
        {
            using (var db = new Cantina())
            {
                // Get all available extras and dishes and store them in the respective lists
                var allExtras = db.Extra.ToList();
                var allDishes = db.Dish.ToList();

                AvailableExtra = allExtras;
                AvailableDish = allDishes;
            }

            this.DisplayDish();
            this.DisplayExtra();
        }

        private void DisplayDish()
        {
            this.availableDishList.DataSource = null;
            this.availableDishList.DataSource = AvailableDish;
        }

        private void DisplayExtra()
        {
            this.availableExtraList.DataSource = null;
            this.availableExtraList.DataSource = AvailableExtra;
        }

        private void addDishToMenu_Click(object sender, EventArgs e)
        {
            var selectedDish = (models.Menu.Dish)this.availableDishList.SelectedItem;

            if (SelectedDish.Count >= maxDishes)
            {
                Error.Warning("You can only add up to 1 dish to the menu");
                return;
            }

            if (selectedDish == null)
            {
                return;
            }

            // Add the selected dish to the SelectedDish list
            SelectedDish.Add(selectedDish);

            this.UpdateCreatedMenuUI();
        }

        private void addExtraToMenu_Click(object sender, EventArgs e)
        {
            var selectedExtra = (models.Menu.Extra)this.availableExtraList.SelectedItem;

            if (SelectedExtra.Count >= maxExtras)
            {
                Error.Warning("You can only add up to 3 extras to the menu");
                return;
            }

            if (selectedExtra == null)
            {
                return;
            }

            // Add the selected extra to the SelectedExtra list
            SelectedExtra.Add(selectedExtra);

            this.UpdateCreatedMenuUI();
        }

        private void UpdateCreatedMenuUI()
        {
            this.addedDishList.DataSource = null;
            this.addedDishList.DataSource = SelectedDish;

            this.addedExtraList.DataSource = null;
            this.addedExtraList.DataSource = SelectedExtra;

            this.CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            this.totalPrice = 0;

            foreach (var extra in SelectedExtra)
            {
                totalPrice += extra.Preco;
            }

            this.CalculateTotalPriceTeacher();
            this.CalculateTotalPriceStudent();
        }

        private void CalculateTotalPriceTeacher()
        {

            this.priceTeacher = this.totalPrice * 0.9m;
            this.totalValueProfessor.Text = this.priceTeacher.ToString() + "€";
        }
        private void CalculateTotalPriceStudent()
        {
            this.priceStudent = this.totalPrice * 0.5m;
            this.totalValueStudent.Text = this.priceStudent.ToString() + "€";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.date = this.dateTimePicker.Value;
            this.menuDefinedDate.Text = this.date.ToString("dd-MM-yyyy");

            //string formattedDate = this.date.ToString("yyyy-MM-dd"); // Format date as "2023-06-19"
            //MessageBox.Show(formattedDate); // Display the formatted date

        }

        private void createPriceStudent_ValueChanged(object sender, EventArgs e)
        {
            this.priceStudent = this.createPriceStudent.Value;
        }

        private void createPriceTeach_ValueChanged(object sender, EventArgs e)
        {
            this.priceTeacher = this.createPriceTeach.Value;
        }

        private void menuStockValue_ValueChanged(object sender, EventArgs e)
        {
            this.menuStock = (int)this.menuStockValue.Value;
        }

        private void menuTypeAlmoco_CheckedChanged(object sender, EventArgs e)
        {
            this.menuType = 0;
            this.UpdateMenuTypeUI();
        }

        private void menuTypeJantar_CheckedChanged(object sender, EventArgs e)
        {
            this.menuType = 1;
            this.UpdateMenuTypeUI();
        }

        private void UpdateMenuTypeUI()
        {
            this.menuDefinedType.Text = this.menuTypeAlmoco.Checked ? "Almoço" : "Jantar";
        }
    }
}
