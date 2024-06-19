using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSI_DA_PL_B.views.Menu.MenuList
{
    public partial class MenuList : Form
    {
        Manager manager { get; set; }
        private Week weekData { get; }
        private int currentWeek { get; set; }
        private int CURRENT_WEEK_VIEW { get; set; }
        private int NEXT_WEEK = 2;
        private int PREVIOUS_WEEK = 1;

        private int selectedMenuId { get; set; }
        List<MenuCanteenExtra> menuExtras { get; set; }
        List<MenuCanteenDish> menuDishes { get; set; }

        List<models.Menu.Dish> dishData { get; set; }
        List<models.Menu.Extra> extraData { get; set; }

        List<MenuCanteen> availableMenus { get; set; }


        public MenuList(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            this.availableMenus = new List<MenuCanteen>();

            this.menuExtras = new List<MenuCanteenExtra>();
            this.menuDishes = new List<MenuCanteenDish>();

            this.dishData = new List<models.Menu.Dish>();
            this.extraData = new List<models.Menu.Extra>();

            this.weekData = new Week();
            this.CURRENT_WEEK_VIEW = this.weekData.GetCurrentYearWeek();
            this.GetMenuCurrentWeek();

            this.LoadMenus(this.CURRENT_WEEK_VIEW);
        }

        public void LoadMenus(int w_id)
        {
            using (var db = new Cantina())
            {
                var menus = db.MenuCantina.Where(m => m.Week == w_id).ToList();

                if (menus.Count == 0)
                {
                    this.menuListDays.ClearSelected();
                    this.menuListDays.SelectedIndex = -1;

                    if (this.availableMenus.Count > 0)
                    {
                        this.availableMenus.Clear();
                    }
                }
                else
                {
                    // Clear the availableMenus list before adding new items
                    this.availableMenus.Clear();

                    foreach (var item in menus)
                    {
                        // Make sure to use the correct constructor parameters
                        MenuCanteen menu = new MenuCanteen
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
            this.menuListDays.DataSource = null;
            this.menuListDays.DataSource = this.availableMenus;
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

        private void createNewMenu_Click(object sender, EventArgs e)
        {
            this.manager.ShowCreateMenuUI();
        }

        private void GetAllExtraByMenuId(int menuId)
        {
            using (var db = new Cantina())
            {
                this.menuExtras = db.MenuCanteenExtras.Where(e => e.MenuCanteenId == menuId).ToList();
            }

            this.extraData.Clear();
            foreach (var item in this.menuExtras)
            {
                this.GetExtraDataById(item.ExtraId);
            }
        }


        private void GetAllDishByMenuId(int menuId)
        {
            using (var db = new Cantina())
            {
                this.menuDishes = db.MenuCanteenDishes.Where(d => d.MenuCanteenId == menuId).ToList();
            }

            this.dishData.Clear();
            foreach (var item in this.menuDishes)
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
                    this.dishData.Add(dishRow);
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
                    this.extraData.Add(extraRow);
                }
            }
            this.UpdateExtraList();
        }

        private void UpdateDishList()
        {
            this.dishList.DataSource = null;
            this.dishList.DataSource = this.dishData;
        }

        private void UpdateExtraList()
        {
            this.extraList.DataSource = null;
            this.extraList.DataSource = this.extraData;
        }

        private void MenuList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }

        private void menuListDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected menu
            var selectedMenu = (MenuCanteen)this.menuListDays.SelectedItem;

            if (selectedMenu == null)
            {
                this.menuType.Text = 
                this.menuQntAvailable.Text =
                this.menuStudentPrice.Text =
                this.menuTeacherPrice.Text =
                this.menuQntAvailable.Text = "--";
                this.dishList.DataSource = null;
                this.extraList.DataSource = null;
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

                    this.menuType.Text = menu.TipoRefeicao == 0 ? "Almoço" : "Jantar";
                    this.menuQntAvailable.Text = menu.Quantidade.ToString();
                    this.menuStudentPrice.Text = menu.PrecoEstudante.ToString() + "€";
                    this.menuTeacherPrice.Text = menu.PrecoProfessor.ToString() + "€";
                }
            }
        }

        private void removeMenu_Click(object sender, EventArgs e)
        {
            var selectedMenu = (MenuCanteen)this.menuListDays.SelectedItem;

            if (selectedMenu == null)
            {
                Error.Warning("Selecione um menu para remover");
                return;
            }

            // remove all dishes and extras from database that are related to the selected menu
            using (var db = new Cantina())
            {
                var menuDishes = db.MenuCanteenDishes.Where(d => d.MenuCanteenId == selectedMenu.Id).ToList();
                var menuExtras = db.MenuCanteenExtras.Where(ex => ex.MenuCanteenId == selectedMenu.Id).ToList();

                if (menuDishes.Count > 0)
                {
                    foreach (var item in menuDishes)
                    {
                        db.MenuCanteenDishes.Remove(item);
                    }
                }

                if (menuExtras.Count > 0)
                {
                    foreach (var item in menuExtras)
                    {
                        db.MenuCanteenExtras.Remove(item);
                    }
                }

                db.SaveChanges();
            }

            // remove the selected menu from the database
            using(var db = new Cantina())
            {
                var menu = db.MenuCantina.FirstOrDefault(m => m.Id == selectedMenu.Id);

                if (menu != null)
                {
                    db.MenuCantina.Remove(menu);
                    db.SaveChanges();
                    this.LoadMenus(this.currentWeek);
                }
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            var selectedMenu = (MenuCanteen)this.menuListDays.SelectedItem;

            this.manager.ShowEditMenuUI(selectedMenu.Id);
        }
    }
}
