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
using static Insurance.PositionWindow;


namespace Insurance.Edit
{
    /// <summary>
    /// Логика взаимодействия для AddPositionWindow.xaml
    /// </summary>
    public partial class AddPositionWindow : Window
    {
        InsuranceEntities db => new InsuranceEntities();
        positions _position = null;
        Action _callback;
        public AddPositionWindow(Action callback, positions pos = null)
        {
            InitializeComponent();
            _callback = callback;

            if (pos != null)
            {
                NameBox.Text = pos.position;
                PriceBox.Text = pos.salary;

                _position = pos;
            }
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PriceBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_position != null)
                {
                    positions positions = db.positions.First(i => i.id == _position.id);
                    positions.position = NameBox.Text;
                    positions.salary = PriceBox.Text;

                    db.Entry(positions).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    positions x = new positions
                    {
                        position = NameBox.Text,
                        salary = PriceBox.Text
                    };
                    db.positions.Add(x);
                }
                db.SaveChanges();
                MessageBox.Show("Сохранение прошло успешно!");
                _callback();
                this.Close();
            }
        }
    }
}
