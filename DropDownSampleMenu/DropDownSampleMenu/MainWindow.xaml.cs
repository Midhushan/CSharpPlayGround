using DropDownSampleMenu.viewmodel;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropDownSampleMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItems>();
            menuRegister.Add(new SubItems("Customesr", new UserControlCustomers()));
            menuRegister.Add(new SubItems("Providers",new UserControlProviders()));
            menuRegister.Add(new SubItems("Employees"));
            menuRegister.Add(new SubItems("Products"));

            var item6 = new itemMenu("Register", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItems>();
            menuSchedule.Add(new SubItems("Service"));
            menuSchedule.Add(new SubItems("Meetings"));
            var item1 = new itemMenu("Appoinments", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItems>();
            menuReports.Add(new SubItems("Customer"));
            menuReports.Add(new SubItems("Provider"));
            menuReports.Add(new SubItems("Product"));
            menuReports.Add(new SubItems("Stock"));
            menuReports.Add(new SubItems("Sales"));

            var item2 = new itemMenu("Reports", menuReports, PackIconKind.FileReport);

            var menuExepenses = new List<SubItems>();
            menuExepenses.Add(new SubItems("Fixed"));
            menuExepenses.Add(new SubItems("Variable"));
            var item3 = new itemMenu("Expenses", menuExepenses, PackIconKind.ShoppingBasket);

            var menuFinacial = new List<SubItems>();
            menuFinacial.Add(new SubItems("Cash Flow"));
            var item4 = new itemMenu("Finacial", menuFinacial, PackIconKind.ScaleBathroom);

       

         
            Menu.Children.Add(new NewUserControlMenuItem(item6, this));
            Menu.Children.Add(new NewUserControlMenuItem(item1, this));
            Menu.Children.Add(new NewUserControlMenuItem(item2, this));
            Menu.Children.Add(new NewUserControlMenuItem(item3, this));
            Menu.Children.Add(new NewUserControlMenuItem(item4, this));

        }
        internal void switchScreen(object sender)
        {
            var screen =((UserControl)sender);
            if (screen!=null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }

        }
    }
}
