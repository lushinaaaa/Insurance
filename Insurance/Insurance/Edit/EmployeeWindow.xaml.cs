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
using System.Data.Entity;

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        private employees _emp;
        InsuranceEntities db => new InsuranceEntities();
        public EmployeeWindow()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            employees[] employee = db.employees.ToArray();
            MainData.ItemsSource = null;
            MainData.ItemsSource = employee;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //AddEmployeeWindow aew = new AddEmployeeWindow(null);
            AddEmployeeWindow aew = new AddEmployeeWindow();
            aew.ShowDialog();
            GetData();
        }

       

        private void MainData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainData.SelectedItem != null)
            {
                employees emp = MainData.SelectedItem as employees;
                AddEmployeeWindow add = new AddEmployeeWindow(emp);
                add.Owner = this;
                add.ShowDialog();
                MainData.SelectedItem = null;
                GetData();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            InsuranceEntities _db = new InsuranceEntities();

            Button button = sender as Button;
            Int32 id = (Int32) button.Tag;

            employees existEmp = _db.employees.FirstOrDefault(emp => emp.id == id);
            if (existEmp == null)
            {
                App.ShowMessage("Сотрудник для удаления не найден");
                return;
            }

            _db.Entry(existEmp).State = EntityState.Deleted;
            _db.SaveChanges();

            App.ShowMessage("Сотрудник удалён");
            GetData();
        }
    }
}
