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

namespace HomeWork23_05_19.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControlSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.SelectedIndex == tabControl.Items.Count - 1)
            {
                (tabControl.Items[tabControl.Items.Count - 1] as TabItem).Header = "New Item";
                (tabControl.Items[tabControl.Items.Count - 1] as TabItem).Content = new WebBrowser() { Source = new Uri("https://google.com") };
                TabItem newTabItem = new TabItem()
                {
                    Header = "+"
                };
                tabControl.Items.Add(newTabItem);
            }
        }
    }
}
