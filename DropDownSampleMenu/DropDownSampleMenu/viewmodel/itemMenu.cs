using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DropDownSampleMenu.viewmodel
{
    public class itemMenu
    {
        public itemMenu(string header, List<SubItems> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;

        }
     

        public string Header { get; private set; }
        public List<SubItems> SubItems { get; private set; }
        public PackIconKind Icon { get; private set; }

        public UserControl Screen { get; private set; }



    }
}
