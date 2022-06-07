using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для WindowDataAgent.xaml
    /// </summary>
    public partial class WindowDataAgent : Window
    {
        private clients _clients;
        InsuranceEntities db = new InsuranceEntities();
        public static List<positions> items { get; set; } = new List<positions>();

        employees Employee;

        public WindowDataAgent(employees emp)
        {
            InitializeComponent();
            Employee = emp;
        }

        private void Positions_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.positions
                        select new
                        {
                            Должность = a.position,
                            Оклад = a.salary
                        };
            mainGrid1.ItemsSource = query.ToList();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.employees
                        join p in db.positions on a.id_position equals p.id
                        select new
                        {
                            ФИО = a.FIO_insurer,
                            Должность = p.position,
                            Адрес = a.address,
                            Паспорт = a.passport,
                            Дата_рождения = a.date_birth
                        };
            mainGrid1.ItemsSource = query.ToList();
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.clients
                        select new
                        {
                            ФИО = a.FIO_client,
                            Дата_рождения = a.date_birth,
                            Паспорт = a.passport,
                            Водительское_удостоверение = a.driving_licence,
                            ПТС = a.PTS
                        };
            mainGrid1.ItemsSource = query.ToList();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.users
                        join emp in db.employees on a.id_employees equals emp.id
                        select new
                        {
                            Логин = a.login,
                            Пароль = a.password,
                            Сотрудник = emp.FIO_insurer
                        };
            mainGrid1.ItemsSource = query.ToList();
        }

        private void Insur_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.insurance
                        join cl in db.clients on a.id_client equals cl.id
                        join cal in db.insurance_calc on a.id_calculation equals cal.id
                        join emp in db.employees on a.id_employee equals emp.id
                        where a.id_employee == Employee.id
                        select new
                        {
                            Страховка = a.insurence,
                            Дата_начала = a.start_date,
                            Дата_истечения = a.end_date,
                            Клиент = cl.FIO_client,
                            Владелец_авто = a.car_owner,
                            Модель = a.car_model,
                            Идентификационный_номер = a.identification_number,
                            Регистрационный_знак = a.registration_number,
                            Стоимость_страховки = cal.total,
                            Сотрудник = emp.FIO_insurer
                        };
            mainGrid1.ItemsSource = query.ToList();
        }

        private void Insur_cal_Click(object sender, RoutedEventArgs e)
        {
            WindowInsurance window = new WindowInsurance(Employee);
            window.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddCl_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow avw = new AddClientWindow(null);
            avw.ShowDialog();
        }


    }
}
