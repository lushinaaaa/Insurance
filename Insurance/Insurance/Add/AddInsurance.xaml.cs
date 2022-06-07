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
using Insurance.Edit;
using Insurance.Model;
using static Insurance.WindowInsurance;

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для AddInsurance.xaml
    /// </summary>
    public partial class AddInsurance : Window
    {
        InsuranceEntities db => new InsuranceEntities();
        insurance _insurance = null;
        insurance_calc _calc = null;
        Action _callback;

        public String TotalPrice => _calc == null ? "Не задана" : $"{_calc.total} руб.";

        public AddInsurance(Action callback, insurance ins = null, employees emp = null)
        {
            InitializeComponent();
            using (InsuranceEntities db = new InsuranceEntities())
            {
                AddCl();
                AddEmp();
                _callback = callback;

                this.DataContext = this;

                if (emp != null)
                {
                    empl.SelectedItem = emp;
                    empl.IsEnabled = false;
                }

                if (ins != null)
                {
                    insurance_calc calc = db.insurance_calc.FirstOrDefault(c => c.id == ins.id_calculation);

                    Insurance.Text = ins.insurence;
                    dateBox1.SelectedDate = ins.start_date;
                    dateBox2.SelectedDate = ins.end_date;
                    Clients.SelectedValue = ins.id_client;
                    owner.Text = ins.car_owner;
                    Model.Text = ins.car_model;
                    Inden.Text = ins.identification_number;
                    Reg.Text = ins.registration_number;
                    empl.SelectedValue = ins.id_employee;

                    _insurance = ins;
                    _calc = calc;
                }
            }

        }

        public void AddCl()
        {
            var result = from cl in db.clients
                         select new
                         {
                             id = cl.id,
                             name = cl.FIO_client
                         };
            Clients.ItemsSource = result.ToList();
            Clients.SelectedValuePath = "id";
            Clients.DisplayMemberPath = "name";
        }

        public void AddEmp()
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

        //public AddInsurance(int id)
        //{
        //    InitializeComponent();
        //    AddCl();
        //    AddInsCal();
        //    AddEmp();
        //    this.Title = "Редактирование страховки";
        //    var Insur = db.insurance.Find(id);
        //    Insurance.Text = Insur.insurence;
        //    dateBox1.SelectedDate = Insur.start_date;
        //    dateBox2.SelectedDate = Insur.end_date;
        //    Clients.SelectedValue = Insur.id_client;
        //    owner.Text = Insur.car_owner;
        //    Model.Text = Insur.car_owner;
        //    Inden.Text = Insur.identification_number;
        //    Reg.Text = Insur.registration_number;
        //    Itog.SelectedValue = Insur.id_calculation;
        //    empl.SelectedValue = Insur.id_employee;
        //    saveButton.Click += EditSaveButton_Click;
        //}

        private void dateBox3_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dateBox1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dateBox2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void client_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void owner_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Model_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Model_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void owner_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Insurance_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Insurance_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Inden_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Inden_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Reg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Reg_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private async void saveButton_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_insurance != null)
                {
                    insurance_calc calc = db.insurance_calc.FirstOrDefault(c => c.id == _calc.id);
                    calc.tb = _calc.tb;
                    calc.kt = _calc.kt;
                    calc.kbm = _calc.kbm;
                    calc.kvs = _calc.kvs;
                    calc.ko = _calc.ko;
                    calc.km = _calc.km;
                    calc.ks = _calc.ks;
                    calc.total = _calc.total;

                    db.Entry(calc).State = System.Data.Entity.EntityState.Modified;
                    await db.SaveChangesAsync();
                }

                else
                {
                    db.insurance_calc.Add(_calc);
                    await db.SaveChangesAsync();
                }

                if (_insurance != null)
                {

                    insurance insurance = db.insurance.First(i => i.id == _insurance.id);
                    insurance.insurence = Insurance.Text;
                    insurance.start_date = (DateTime)dateBox1.SelectedDate;
                    insurance.end_date = (DateTime)dateBox2.SelectedDate;
                    insurance.id_client = (int)Clients.SelectedValue;
                    insurance.car_owner = owner.Text;
                    insurance.car_model = Model.Text;
                    insurance.identification_number = Inden.Text;
                    insurance.registration_number = Reg.Text;
                    insurance.id_calculation = _calc.id;
                    insurance.id_employee = (int)empl.SelectedValue;

                    db.Entry(insurance).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    insurance_calc existCalc = db.insurance_calc.ToArray().Last();

                    insurance x = new insurance
                    {
                        insurence = Insurance.Text,
                        start_date = (DateTime)dateBox1.SelectedDate,
                        end_date = (DateTime)dateBox2.SelectedDate,
                        id_client = (int)Clients.SelectedValue,
                        car_owner = owner.Text,
                        car_model = Model.Text,
                        identification_number = Inden.Text,
                        registration_number = Reg.Text,
                        id_calculation = existCalc.id,
                        id_employee = (int)empl.SelectedValue
                    };
                    db.insurance.Add(x);
                }

                db.SaveChanges();
                MessageBox.Show("Сохранение прошло успешно!");

            }
            _callback();
            this.Close();

        }
    

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            CountInsurance ci = new CountInsurance(SetInsuranceCalc, _insurance?.id_calculation);
            ci.ShowDialog();
        }

        private void Itog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Empl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SetInsuranceCalc(insurance_calc calc)
        {
            _calc = calc;
            this.DataContext = null;
            this.DataContext = this;
        }
    }
}
