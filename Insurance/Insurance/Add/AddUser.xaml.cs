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
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        InsuranceEntities db => new InsuranceEntities();
        users _users = null;
        Action _callback;
        public AddUser(Action callback, users us = null)
        {
            InitializeComponent();
            AddEmp();
            _callback = callback;

            if (us != null)
            {
                empl.SelectedValue = us.id_employees;
                role.Text = Convert.ToString(us.role);
                login.Text = us.login;
                password.Text = us.password;
                
                _users = us;
            }
        }

        public void AddEmp()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                var result = from emp in db.employees
                         select new
                         {
                             id = emp.id,
                             name = emp.FIO_insurer
                         };
            empl.ItemsSource = result.ToList();
            empl.SelectedValuePath = "id";
            empl.DisplayMemberPath = "name";
            }
            
        }

        private void Empl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Role_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Login_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_users != null)
                {
                    users users = db.users.First(i => i.id == _users.id);
                    users.id_employees = (int)empl.SelectedValue;
                    users.role = Convert.ToInt32(role.Text);
                    users.login = login.Text;
                    users.password = password.Text;


                    db.Entry(users).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    users x = new users
                    {
                        id_employees = (int)empl.SelectedValue,
                        role = Convert.ToInt32(role.Text),
                        login = login.Text,
                        password = password.Text
                    };
                    db.users.Add(x);
                }
                db.SaveChanges();
                MessageBox.Show("Сохранение прошло успешно!");
                _callback();
                this.Close();
            }
        }
    }
}
