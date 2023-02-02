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
using System.Windows.Shapes;

namespace chatikCustomer
{
    /// <summary>
    /// Логика взаимодействия для ListProjectsWindow.xaml
    /// </summary>
    public partial class ListProjectsWindow : Window
    {
        User user;
        public ListProjectsWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            ListProjects.ItemsSource = MongoExamples.GetProjectsCustomers(user);
        }

        private void ListProjects_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Project project = ListProjects.SelectedItem as Project;
            ChatWindow chatWindow = new ChatWindow(user, project);
            chatWindow.Show();
            this.Close();
        }
    }
}
