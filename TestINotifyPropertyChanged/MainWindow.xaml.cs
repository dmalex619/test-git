using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TestINotifyPropertyChanged
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel model = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = model;
        }

        private void BtnTime_Click(object sender, RoutedEventArgs e)
        {
            model.CurrentTime = DateTime.Now.ToLongTimeString();
        }

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            model.RandNumber = new Random().Next();
        }

        public async void GetSomething()
        {
            // Кортежи определены в версии .Net 4.7
            (int x, int y) tpl = (12, 45);
            Console.WriteLine($"{tpl.x}   {tpl.y}");
            string hello = "Hello";
            decimal dec = 123.0M;

            // Async/await определены в версии .Net 4.5
            await Task.Run(() => Thread.Sleep(1000) );
        }
    }
}
