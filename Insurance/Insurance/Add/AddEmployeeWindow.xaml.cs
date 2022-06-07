using Insurance.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

namespace Insurance.Edit
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        InsuranceEntities db = new InsuranceEntities();
        employees empl;
        private byte[] newByteImage;
        string pathImage;
        string PathImage
        {
            get
            {
                return pathImage;
            }
            set
            {
                pathImage = value;
            }
        }
        string sPathImage
        {
            get
            {
                return pathImage.Substring(1);
            }
        }

        public AddEmployeeWindow(employees emp = null)
        {
            InitializeComponent();
            AddPos();

            if (emp != null)
            {
                empl = emp;

                fNameBox.Text = emp.FIO_insurer;
                PhoneBox.Text = emp.phone;
                VUBox.Text = emp.address;
                PassBox.Text = emp.passport;
                PosBox.Text = emp.positions.position;
                dateBox.SelectedDate = emp.date_birth;

                MemoryStream ms = new MemoryStream(emp.Photo);

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = ms;
                image.EndInit();

                PhotoImageBox.Source = image;
                PathImage = emp.photo;
                PhotoTextBox.Visibility = Visibility.Hidden;
            }
        }
        public void AddPos()
        {
            var res = from pos in db.positions
                      select new
                      {
                          id = pos.id,
                          name = pos.position
                      };
            PosBox.ItemsSource = res.ToList();
            PosBox.SelectedValuePath = "id";
            PosBox.DisplayMemberPath = "name";
        }

        //employees Employee;
        //public AddEmployeeWindow(employees employee)
        //{
        //    InitializeComponent();
        //    Employee = employee;
        //    if (Employee != null)
        //    {
        //        fNameBox.Text = Employee.FIO_insurer;
        //        PhoneBox.Text = Employee.phone;
        //        VUBox.Text = Employee.address;
        //        PassBox.Text = Employee.passport;
        //        PosBox.Text = Employee.positions.position;
        //        dateBox.SelectedDate = Employee.date_birth;

        //        MemoryStream ms = new MemoryStream(Employee.Photo);

        //        BitmapImage image = new BitmapImage();
        //        image.BeginInit();
        //        image.StreamSource = ms;
        //        image.EndInit();

        //        PhotoImageBox.Source = image;
        //    }
    //}
        private void PosBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FNameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PassBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void VUBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VUBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DateBox_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            String fName = fNameBox.Text;
            if (String.IsNullOrWhiteSpace(fName))
            {
                App.ShowMessage("Введите ФИО для сотрудника");
                return;
            }

            String phone = PhoneBox.Text;
            if (String.IsNullOrWhiteSpace(phone))
            {
                App.ShowMessage("Введите телефон для сотрудника");
                return;
            }

            String add = PhoneBox.Text;
            if (String.IsNullOrWhiteSpace(add))
            {
                App.ShowMessage("Введите адрес для сотрудника");
                return;
            }

            String pass = PhoneBox.Text;
            if (String.IsNullOrWhiteSpace(pass))
            {
                App.ShowMessage("Введите паспортные данные для сотрудника");
                return;
            }

            int? pos = (int)PosBox.SelectedValue;
            if (pos == null)
            {
                App.ShowMessage("Выберите должность для сотрудника");
                return;
            }

            DateTime? date = (DateTime)dateBox.SelectedDate;
            if (date == null)
            {
                App.ShowMessage("Выберите дату для сотрудника");
                return;
            }

            if (empl != null)
            {
                employees existEmpl = db.employees.First(emp => emp.id == empl.id);
                existEmpl.FIO_insurer = fNameBox.Text;
                existEmpl.phone = PhoneBox.Text;
                existEmpl.address = VUBox.Text;
                existEmpl.passport = PassBox.Text;
                existEmpl.id_position = (int)PosBox.SelectedValue;
                existEmpl.date_birth = (DateTime)dateBox.SelectedDate;
                existEmpl.photo = PathImage;

                db.Entry(existEmpl).State = EntityState.Modified;
            }
            else
            {
                employees Employee = new employees
                {
                    FIO_insurer = fNameBox.Text,
                    phone = PhoneBox.Text,
                    address = VUBox.Text,
                    passport = PassBox.Text,
                    id_position = (int)PosBox.SelectedValue,
                    date_birth = (DateTime)dateBox.SelectedDate,
                    photo = PathImage
                };

                db.employees.Add(Employee);
            }

            db.SaveChanges();
            MessageBox.Show("Сохранение прошло успешно");
            this.Hide();

            //String fio = fNameBox.Text;
            //if (String.IsNullOrWhiteSpace(fio))
            //{
            //    App.ShowMessage("Введите ФИО");
            //    return;
            //}

            //positions position = PosBox.SelectedItem as positions;
            //if (position == null)
            //{
            //    App.ShowMessage("Выберите должность");
            //    return;
            //}

            //String address = VUBox.Text;
            //if (String.IsNullOrWhiteSpace(address))
            //{
            //    App.ShowMessage("Введите адрес");
            //    return;
            //}

            //String phone = PhoneBox.Text;
            //if (String.IsNullOrWhiteSpace(phone))
            //{
            //    App.ShowMessage("Введите телефон");
            //    return;
            //}

            //String passport = PassBox.Text;
            //if (String.IsNullOrWhiteSpace(passport))
            //{
            //    App.ShowMessage("Введите паспорт");
            //    return;
            //}

            //Image photo = PhotoImageBox;
            //if (photo == null)
            //{
            //    App.ShowMessage("Вставьте фотографию");
            //    return;
            //}

            //employees employee = new employees();
            //employee.id_position = position.id;
            //employee.FIO_insurer = fio;
            //employee.address = address;
            //employee.phone = phone;
            //employee.passport = passport;
            //employee.photo = PathImage;

            //db.employees.Add(employee);
            //db.SaveChanges();

            //App.ShowMessage("Сохранение прошло успешно");
            //this.Close();


        }

        private void PhoneBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void ImageChoiceButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string[] extensions = { ".jpg", ".bmp", ".png", ".jpeg" };
            if (ofd.ShowDialog() == true)
            {

                if (extensions.Contains(System.IO.Path.GetExtension(ofd.FileName)))
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        newByteImage = new byte[fs.Length];
                        fs.Read(newByteImage, 0, newByteImage.Length);
                    }

                    MemoryStream ms = new MemoryStream(newByteImage);

                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.StreamSource = ms;
                    image.EndInit();

                    PhotoImageBox.Source = image;
                    PhotoTextBox.Content = "";

                    PathImage = $"/agents/{System.IO.Path.GetFileName(ofd.FileName)}";

                    var encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    using (FileStream stream = new FileStream(PathImage.Substring(1), FileMode.Create)) encoder.Save(stream);
                }
                else
                {
                    MessageBox.Show("Выбранный файл не является фотографией", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
