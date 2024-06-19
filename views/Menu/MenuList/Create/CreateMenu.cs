using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int fromTime { get; set; }
        private int toTime { get; set; }

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
                using (var db = new Cantina())
                {
                    // Create a new menu
                    MenuCanteen menu = new MenuCanteen(date, toTime - fromTime, priceStudent, priceTeacher, SelectedDish, SelectedExtra);


                    db.MenuCantina.Add(menu);
                    db.SaveChanges();
                }
                this.manager.ShowMenuListUI();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Error.Err($"Entity: {eve.Entry.Entity.GetType().Name}, Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                var errorMessage = new StringBuilder();
                var currentException = ex;

                while (currentException != null)
                {
                    errorMessage.AppendLine($"Exception: {currentException.Message}");
                    currentException = currentException.InnerException;
                }

                Error.Err(errorMessage.ToString());
            }
        }



        private void LoadDataFromDatabase()
        {
            using(var db = new Cantina())
            {
                // Get all available extras and dished and store them in the respective lists

                var allExtras = db.Extra.ToList();
                var allDishes = db.Dish.ToList();

                foreach (var extra in allExtras)
                {
                    models.Menu.Extra newExtra = new models.Menu.Extra(extra.Descricao, extra.Preco, extra.Ativo);
                    AvailableExtra.Add(newExtra);
                }

                foreach (var dish in allDishes)
                {
                    models.Menu.Dish newDish = new models.Menu.Dish(dish.Description, dish.Type, dish.Active);
                    AvailableDish.Add(newDish);
                }
            }

            this.DisaplyDish();
            this.DisplayExtra();
        }

        private void DisaplyDish()
        {
            this.availableDishList.DataSource = null;
            this.availableDishList.DataSource = AvailableDish;
        }

        private void DisplayExtra()
        {
            this.availableExtraList.DataSource = null;
            this.availableExtraList.DataSource = AvailableExtra;
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

            models.Menu.Extra newExtra = new models.Menu.Extra(selectedExtra.Descricao, selectedExtra.Preco, selectedExtra.Ativo);
            SelectedExtra.Add(selectedExtra);

            this.UpdateCreatedMenuUI();
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

            models.Menu.Dish newDish = new models.Menu.Dish(selectedDish.Description, selectedDish.Type, selectedDish.Active);
            SelectedDish.Add(newDish);

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

            this.menuTotalPrice.Text = $"Valor Total: {this.totalPrice}€";

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

        private void createStartTime_ValueChanged(object sender, EventArgs e)
        {
            decimal time = this.createStartTime.Value;
            this.fromTime = (int)time;
        }

        private void createEndTime_ValueChanged(object sender, EventArgs e)
        {
            decimal time = this.createEndTime.Value;
            this.toTime = (int)time;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.date = this.dateTimePicker.Value;
        }

        private void createPriceStudent_ValueChanged(object sender, EventArgs e)
        {
            this.priceStudent = this.createPriceStudent.Value;
        }

        private void createPriceTeach_ValueChanged(object sender, EventArgs e)
        {
            this.priceTeacher = this.createPriceTeach.Value;
        }
    }
}
