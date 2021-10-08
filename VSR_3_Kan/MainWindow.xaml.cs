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

namespace VSR_3_Kan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VSR_1_KanEntities1 con;
        public MainWindow()
        {
            InitializeComponent();
            con = new VSR_1_KanEntities1();
            ShowTable();
        }
        private void ShowTable()
        {
            Table_1.ItemsSource = con.Table_1.ToList();
        }
    }
}
