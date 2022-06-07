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

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для WindowData.xaml
    /// </summary>
    public partial class WindowData : Window
    {
        InsuranceEntities db = new InsuranceEntities();
        public static List<positions> items { get; set; } = new List<positions>();
        public WindowData()
        {
            InitializeComponent();
        }

        private void positions_Click(object sender, RoutedEventArgs e)
        {
                var query = from a in db.positions
                             select new
                             {
                                 Должность = a.position,
                                 Оклад = a.salary
                             };
                    mainGrid.ItemsSource = query.ToList();
        }

        private void employees_Click(object sender, RoutedEventArgs e)
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
            mainGrid.ItemsSource = query.ToList();
        }

        private void clients_Click(object sender, RoutedEventArgs e)
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
            mainGrid.ItemsSource = query.ToList();
        }

        private void users_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.users
                        join emp in db.employees on a.id_employees equals emp.id
                        select new
                        {
                            Логин = a.login,
                            Пароль = a.password,
                            Сотрудник = emp.FIO_insurer
                        };
            mainGrid.ItemsSource = query.ToList();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow ew = new EditWindow();
            ew.ShowDialog();
        }

        private void Insur_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.insurance
                        join cl in db.clients on a.id_client equals cl.id
                        join cal in db.insurance_calc on a.id_calculation equals cal.id
                        join emp in db.employees on a.id_employee equals emp.id
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
            mainGrid.ItemsSource = query.ToList();
        }

        private void Insur_cal_Click(object sender, RoutedEventArgs e)
        {
            var query = from a in db.insurance_calc
                        select new
                        {
                            Базовый_тариф = a.tb,
                            Коэффициент_территории = a.kt,
                            Коэффициент_бонус_малус = a.kbm,
                            Коэффициент_возраста_и_стажа = a.kvs,
                            Коэффициент_ограничений = a.ko,
                            Коэффициент_мощности_двигателя = a.km,
                            Коэффициент_периода_использования = a.ks,
                            Итоговая_стоимость = a.total
                        };
            mainGrid.ItemsSource = query.ToList();
        }
    }
}
