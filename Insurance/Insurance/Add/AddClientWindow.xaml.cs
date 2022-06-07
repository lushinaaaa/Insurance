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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        InsuranceEntities db => new InsuranceEntities();

        clients _clients = null;
        Action _callback;
        public AddClientWindow(Action callback, clients cl = null)
        {
            InitializeComponent();

            _callback = callback;

            if (cl != null)
            {
                fNameBox.Text = cl.FIO_client;
                dateBox.Text = Convert.ToString(cl.date_birth);
                PassBox.Text = cl.passport;
                VUBox.Text = cl.driving_licence;
                PTSBox.Text = cl.PTS;

                _clients = cl;
            }
        }

        private void FNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VUBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PTSBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DateBox_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SexBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_clients != null)
                {
                    clients clients = db.clients.First(i => i.id == _clients.id);
                    clients.FIO_client = fNameBox.Text;
                    clients.date_birth = Convert.ToDateTime(dateBox.Text);
                    clients.passport = PassBox.Text;
                    clients.driving_licence = VUBox.Text;
                    clients.PTS = PTSBox.Text;


                    db.Entry(clients).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    clients x = new clients
                    {
                        FIO_client = fNameBox.Text,
                        date_birth = Convert.ToDateTime(dateBox.Text),
                        passport = PassBox.Text,
                        driving_licence = VUBox.Text,
                        PTS = PTSBox.Text
                };
                    db.clients.Add(x);
                }
                db.SaveChanges();
                MessageBox.Show("Сохранение прошло успешно!");
                _callback();
                this.Close();
            }
        }

        private void FNameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PassBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void VUBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PTSBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
