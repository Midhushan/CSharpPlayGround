using DropDownSampleMenu.viewmodel;
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
    /// Interaction logic for NewUserControlMenuItem.xaml
    /// </summary>
    public partial class NewUserControlMenuItem : UserControl
    {
        MainWindow _context;
        public NewUserControlMenuItem(itemMenu itemMenu, MainWindow context)
        {
            InitializeComponent();
            _context = context;

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.switchScreen(((SubItems)((ListView)sender).SelectedItem).Screen);
        }
    }
}
