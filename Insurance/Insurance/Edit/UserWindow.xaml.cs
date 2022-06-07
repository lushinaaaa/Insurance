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
namespace Insurance.Edit
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private users _users;
        InsuranceEntities db => new InsuranceEntities();
        public static List<positions> items { get; set; } = new List<positions>();
        public UserWindow()
        {
                InitializeComponent();
                GetUser();

                List<employees> empl = db.employees.ToList();
                employees all = new employees { id = -1 };
                empl = empl.ToList();
                Empl.ItemsSource = empl;
                Empl.SelectedIndex = 0;
            
        }
        public void GetUser()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                injuredGrid.ItemsSource = null;
                injuredGrid.Items.Refresh();
                var query = db.users.ToArray();
                injuredGrid.ItemsSource = query.ToList();
            }
        }

        void filter(employees value)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (value.id == -1)
                {
                    GetUser();
                }
                else
                {
                    injuredGrid.ItemsSource = null;
                    injuredGrid.Items.Refresh();
                    var query = db.users.Where(a => a.employees.id == value.id).ToArray();
                    injuredGrid.ItemsSource = query.ToList();
                }
            }
        }

       

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddUser au = new AddUser(GetUser);
            au.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (_users != null)
            {
                AddUser window = new AddUser(GetUser, _users);
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (_users != null)
            {
                InsuranceEntities dbremove = new InsuranceEntities();
                users pr = dbremove.users
                   .Where(o => o.id == _users.id)
                   .FirstOrDefault();
                dbremove.users.Remove(pr);
                dbremove.SaveChanges();
                dbremove.Dispose();
                MessageBox.Show("Удаление прошло успешно", "Выполнено");
                _users = null;
                GetUser();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void Empl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filter(Empl.SelectedItem as employees);
        }

        private void InjuredGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (injuredGrid.SelectedValue != null)
            {
                users us = injuredGrid.SelectedValue as users;
                if (us == null) return;

                _users = us;
            }
        }
    }
}
