using System.Windows.Controls;

namespace DropDownSampleMenu.viewmodel
{
    public class SubItems
    {

        public SubItems(string name, UserControl screen = null)
        {
            Name = name;
            Screen = screen;
        }

        public string Name { get; private set; }
        public UserControl Screen { get; private set; }
    }
}