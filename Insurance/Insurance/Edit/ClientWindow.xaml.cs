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
using Insurance.Model;
using Insurance.Edit;

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        private clients _clients;
        InsuranceEntities db => new InsuranceEntities();
        public ClientWindow()
        {
            InitializeComponent();
            GetCl();
        }

        public void GetCl()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                injuredGrid.ItemsSource = null;
                injuredGrid.Items.Refresh();
                var query = db.clients.ToArray();
                injuredGrid.ItemsSource = query.ToList();
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow acw = new AddClientWindow(GetCl);
            acw.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (_clients != null)
            {
                AddClientWindow window = new AddClientWindow(GetCl, _clients);
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (_clients != null)
            {
                InsuranceEntities dbremove = new InsuranceEntities();
                clients pr = dbremove.clients
                   .Where(o => o.id == _clients.id)
                   .FirstOrDefault();
                dbremove.clients.Remove(pr);
                dbremove.SaveChanges();
                dbremove.Dispose();
                MessageBox.Show("Удаление прошло успешно", "Выполнено");
                _clients = null;
                GetCl();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void FNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {

                String text = fNameBox.Text.ToLower();

                var query = db.clients.ToList();
                injuredGrid.ItemsSource = query;

                clients[] clients = db.clients
                    .Where(x => x.FIO_client.ToLower().StartsWith(text) || x.PTS.ToLower().StartsWith(text)).ToArray();

                injuredGrid.ItemsSource = null;
                injuredGrid.ItemsSource = clients;
            }
        }

        private void FNameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
               
        }

        private void InjuredGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (injuredGrid.SelectedValue != null)
            {
                clients cl = injuredGrid.SelectedValue as clients;
                if (cl == null) return;

                _clients = cl;
            }
        }
    }
}
