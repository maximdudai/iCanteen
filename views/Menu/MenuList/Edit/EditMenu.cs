using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;

namespace PSI_DA_PL_B.views.Menu.MenuList.Edit
{
    public partial class EditMenu : Form
    {
        Manager manager { get; set; }
        DateTime date { get; set; }
        private int menuStock { get; set; } = 1;

        private decimal priceStudent { get; set; }
        private decimal priceTeacher { get; set; }

        List<models.Menu.Extra> AvailableExtra { get; set; }
        List<models.Menu.Dish> AvailableDish { get; set; }

        List<models.Menu.Extra> SelectedExtra { get; set; }
        List<models.Menu.Dish> SelectedDish { get; set; }

        private int maxExtras { get; set; } = 3;
        private int maxDishes { get; set; } = 1;

        private decimal totalPrice { get; set; }
        private int menuType { get; set; }

        int Week { get; set; }
        Week weekData { get; set; }

        private int menuId { get; set; }

        public EditMenu(int menuId, Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
            AvailableExtra = new List<models.Menu.Extra>();
            AvailableDish = new List<models.Menu.Dish>();
            SelectedExtra = new List<models.Menu.Extra>();
            SelectedDish = new List<models.Menu.Dish>();

            this.date = DateTime.Now;
            this.menuDefinedDate.Text = this.date.ToString("dd-MM-yyyy");

            this.weekData = new Week();
            this.Week = weekData.GetCurrentYearWeek();

            this.menuId = menuId;

            LoadDataFromDatabase();
            LoadExistingMenuData(menuId);
        }

        private void LoadExistingMenuData(int menuId)
        {
            try
            {
                using (var db = new Cantina())
                {
                    var menu = db.MenuCantina.FirstOrDefault(m => m.Id == menuId);
                    if (menu != null)
                    {
                        this.date = menu.Data;
                        this.menuStock = menu.Quantidade;
                        this.priceStudent = menu.PrecoEstudante;
                        this.priceTeacher = menu.PrecoProfessor;
                        this.menuType = menu.TipoRefeicao;

                        // UI elements
                        this.menuStockValue.Value = this.menuStock;
                        this.createPriceStudent.Value = this.priceStudent;
                        this.createPriceTeach.Value = this.priceTeacher;
                        this.dateTimePicker.Value = this.date;

                        this.menuTypeAlmoco.Checked = (menu.TipoRefeicao == 0);
                        this.menuTypeJantar.Checked = (menu.TipoRefeicao == 1);

                        this.menuDefinedDate.Text = this.date.ToString("dd-MM-yyyy");
                        this.menuDefinedType.Text = menu.TipoRefeicao == 0 ? "Almoço" : "Jantar";

                        this.GetAllDishByMenuId(menuId);
                        this.GetAllExtraByMenuId(menuId);

                        UpdateCreatedMenuUI();
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        private void createMenuList_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedDish.Count == 0)
                {
                    Error.Warning("You must select at least 1 dish to create a menu");
                    return;
                }

                if (this.menuTypeAlmoco.Checked == false && this.menuTypeJantar.Checked == false)
                {
                    Error.Warning("You must select a menu type to create a menu");
                    return;
                }

                using (var db = new Cantina())
                {
                    var menu = db.MenuCantina.FirstOrDefault(m => m.Id == this.menuId);

                    if (menu != null)
                    {
                        menu.Data = this.date.Date;
                        menu.TipoRefeicao = this.menuType;
                        menu.Quantidade = this.menuStock;
                        menu.PrecoEstudante = this.priceStudent;
                        menu.PrecoProfessor = this.priceTeacher;
                        menu.Week = this.weekData.GetWeekFromDay(this.date);

                        // Remove existing entries in MenuCanteenDishes and MenuCanteenExtras
                        var existingDishes = db.MenuCanteenDishes.Where(de => de.MenuCanteenId == this.menuId).ToList();
                        db.MenuCanteenDishes.RemoveRange(existingDishes);

                        var existingExtras = db.MenuCanteenExtras.Where(ex => ex.MenuCanteenId == this.menuId).ToList();
                        db.MenuCanteenExtras.RemoveRange(existingExtras);

                        // Add new entries
                        foreach (var dish in SelectedDish)
                        {
                            var menuCanteenDish = new MenuCanteenDish
                            {
                                MenuCanteenId = menu.Id,
                                DishId = dish.itemId
                            };
                            db.MenuCanteenDishes.Add(menuCanteenDish);
                        }

                        foreach (var extra in SelectedExtra)
                        {
                            var menuCanteenExtra = new MenuCanteenExtra
                            {
                                MenuCanteenId = menu.Id,
                                ExtraId = extra.itemId
                            };
                            db.MenuCanteenExtras.Add(menuCanteenExtra);
                        }

                        // Save changes to the database
                        db.SaveChanges();

                        this.manager.ShowMenuListUI();
                    }
                    else
                    {
                        Console.WriteLine($"Menu with id {this.menuId} not found");
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }




        private void GetAllExtraByMenuId(int menuId)
        {
            try
            {
                using (var db = new Cantina())
                {
                    var extras = db.MenuCanteenExtras
                                   .Where(e => e.MenuCanteenId == menuId)
                                   .Select(e => e.ExtraId)
                                   .ToList();

                    this.SelectedExtra.Clear();
                    foreach (var extraId in extras)
                    {
                        this.GetExtraDataById(extraId);
                    }
                }

                this.UpdateExtraList();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }



        private void GetAllDishByMenuId(int menuId)
        {
            try
            {
                using (var db = new Cantina())
                {
                    var dishes = db.MenuCanteenDishes
                                   .Where(d => d.MenuCanteenId == menuId)
                                   .Select(d => d.DishId)
                                   .ToList();

                    this.SelectedDish.Clear();
                    foreach (var dishId in dishes)
                    {
                        this.GetDishDataById(dishId);
                    }
                }

                this.UpdateDishList();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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
                    dishRow.itemId = dish.itemId;
                    this.SelectedDish.Add(dishRow);
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
                    extraRow.itemId = extra.itemId;
                    this.SelectedExtra.Add(extraRow);
                }
            }
            this.UpdateExtraList();
        }

        private void UpdateDishList()
        {
            this.addedDishList.DataSource = null;
            this.addedDishList.DataSource = this.SelectedDish;
        }

        private void UpdateExtraList()
        {
            this.addedExtraList.DataSource = null;
            this.addedExtraList.DataSource = this.SelectedExtra;
        }

        private void LoadDataFromDatabase()
        {
            using (var db = new Cantina())
            {
                AvailableExtra = db.Extra.ToList();
                AvailableDish = db.Dish.ToList();
            }

            DisplayDish();
            DisplayExtra();
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
            try
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

                SelectedDish.Add(selectedDish);
                UpdateCreatedMenuUI();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void addExtraToMenu_Click(object sender, EventArgs e)
        {
            try
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

                SelectedExtra.Add(selectedExtra);
                UpdateCreatedMenuUI();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
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
            try
            {
                totalPrice = 0;

                foreach (var extra in SelectedExtra)
                {
                    totalPrice += extra.Preco;
                }

                CalculateTotalPriceTeacher();
                CalculateTotalPriceStudent();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void CalculateTotalPriceTeacher()
        {
            priceTeacher = totalPrice * 0.9m;
            priceForTeacher.Text = priceTeacher.ToString() + "€";
        }

        private void CalculateTotalPriceStudent()
        {
            priceStudent = totalPrice * 0.5m;
            priceForStudent.Text = priceStudent.ToString() + "€";
        }


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.date = this.dateTimePicker.Value;
            this.menuDefinedDate.Text = this.date.ToString("dd-MM-yyyy");
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

        private void EditMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ShowMenuListUI();
        }

        private void addedDishList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedDish = (models.Menu.Dish)this.addedDishList.SelectedItem;

                if (selectedDish == null)
                {
                    return;
                }

                using (var db = new Cantina())
                {
                    var dishToRemove = db.MenuCanteenDishes
                                         .FirstOrDefault(d => d.DishId == selectedDish.itemId && d.MenuCanteenId == this.menuId);

                    if (dishToRemove == null)
                    {
                        Console.WriteLine($"Dish with id {selectedDish.itemId} not found in MenuCanteenDishes");
                        return;
                    }

                    db.MenuCanteenDishes.Remove(dishToRemove);
                    db.SaveChanges();
                }

                SelectedDish.Remove(selectedDish);

                UpdateCreatedMenuUI();
                CalculateTotalPrice();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        private void addedExtraList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedExtra = (models.Menu.Extra)this.addedExtraList.SelectedItem;

                if (selectedExtra == null)
                {
                    return;
                }

                using (var db = new Cantina())
                {
                    var extraToRemove = db.MenuCanteenExtras
                                         .FirstOrDefault(ex => ex.ExtraId == selectedExtra.itemId && ex.MenuCanteenId == this.menuId);

                    if (extraToRemove == null)
                    {
                        Console.WriteLine($"Extra with id {selectedExtra.itemId} not found in MenuCanteenExtras");
                        return;
                    }

                    db.MenuCanteenExtras.Remove(extraToRemove);
                    db.SaveChanges();
                }

                SelectedExtra.Remove(selectedExtra);

                UpdateCreatedMenuUI();
                CalculateTotalPrice();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

    }
}
