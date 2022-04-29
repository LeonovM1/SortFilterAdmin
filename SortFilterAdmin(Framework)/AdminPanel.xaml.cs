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

namespace SortFilterAdmin_Framework_
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {


        public AdminPanel()
        {
            InitializeComponent();
            DGrid.ItemsSource = msEntities.GetContext().Users.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow((sender as Button).DataContext as Users);
            updateWindow.Show();
            this.Close();
        }

        private void PanelButtonNew_Click(object sender, RoutedEventArgs e)
        {

            UpdateWindow updateWindow = new UpdateWindow(null);
            updateWindow.Show();
            this.Close();

        }

        private void PanelButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var UsersForRemoving = DGrid.SelectedItems.Cast<Users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {UsersForRemoving.Count()} элементов? ", "Внимание!", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {

                    msEntities.GetContext().Users.RemoveRange(UsersForRemoving);
                    msEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }
    }
}
