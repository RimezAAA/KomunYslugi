using KomunYslugi.Data;
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

namespace chatikCustomer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasBox.Password != String.Empty && LogBox.Text != String.Empty)
            {
                User temp = MongoExamples.Find(LogBox.Text);
                if (temp != null)
                {
                    if (temp.UserType == "Customer")
                    {
                        if (temp.Password == PasBox.Password)
                        {
                            ListProjectsWindow listProjectsWindow = new ListProjectsWindow(temp);
                            listProjectsWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы зашли не под заказчиком!");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Заполните!");
            }
        }
    }
}
