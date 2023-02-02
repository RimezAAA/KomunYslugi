using KomunYslugi.Data;
using Microsoft.AspNetCore.SignalR.Client;
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
    /// Логика взаимодействия для ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        HubConnection connection;  // подключение для взаимодействия с хабом
        Project project;
        User user;
        public ChatWindow(User user, Project project)
        {
            this.user = user;
            this.project = project;
            InitializeComponent();
            // создаем подключение к хабу
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7161/c3hat")
                .Build();


            // регистрируем функцию Receive для получения данных
            connection.On<string, string, string, string>("Receive", (message, user, recipient_id, sender_id) =>
            {
                Dispatcher.Invoke(() =>
                {//доделать
                    if (this.user._id.ToString() == recipient_id && (project.designer._id.ToString() == sender_id || project.developer._id.ToString() == sender_id))
                    {
                        var newMessage = $"{user}: {message}";
                        chatbox.Items.Insert(0, newMessage);
                    }
                });
            });
        }

        // обработчик загрузки окна
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // подключемся к хабу
                await connection.StartAsync();
                chatbox.Items.Add("Вы вошли в чат");
                sendBtn.IsEnabled = true;
            }
            catch (Exception ex)
            {
                chatbox.Items.Add(ex.Message);
            }
        }
        // обработчик нажатия на кнопку
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // отправка сообщения
                await connection.InvokeAsync("Send", messageTextBox.Text, userTextBox.Text);
            }
            catch (Exception ex)
            {
                chatbox.Items.Add(ex.Message);
            }
        }
    }
}
