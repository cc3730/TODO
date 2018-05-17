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

namespace To_Do_List
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle rect = new Rectangle();
            //rect.Width = 50;
            //rect.Height = 30;
            //rect.Fill = Brushes.Red;
            //rect.Margin = new Thickness(0, 0, 0, 5);

            Todoitem item = new Todoitem();

            TodoList.Children.Add(item);
        }

       
        private void SaveBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //取得每一個item的文字
            List<string> all = new List<string>();

            foreach(Todoitem item in TodoList.Children)
            {
                all.Add(item.GetTaskName());
            }

            //寫入檔案
            System.IO.File.WriteAllLines(@"c:\Aaaa.txt", all);
        }
    }
}
