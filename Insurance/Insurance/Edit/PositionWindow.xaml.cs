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
    /// Логика взаимодействия для PositionWindow.xaml
    /// </summary>
    public partial class PositionWindow : Window
    {
        private positions _position;
        
        public PositionWindow()
        {
            InitializeComponent();

            GetPos();

            //var query = from a in db.positions
            //            select new
            //            {
            //                Должность = a.position,
            //                Оклад = a.salary
            //            };
            //MainGrid.ItemsSource = query.ToList();

        }

        public void GetPos()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                MainGrid.ItemsSource = null;
                MainGrid.Items.Refresh();
                var query = db.positions.ToArray();
                MainGrid.ItemsSource = query.ToList();
            } 
        }
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddPositionWindow apw = new AddPositionWindow(GetPos);
            apw.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_position != null)
                {
                    AddPositionWindow window = new AddPositionWindow(GetPos, _position);
                    window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите строку", "Внимание");
                }
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (_position != null)
                {
                    InsuranceEntities dbremove = new InsuranceEntities();
                    positions pr = dbremove.positions
                       .Where(o => o.id == _position.id)
                       .FirstOrDefault();
                    dbremove.positions.Remove(pr);
                    dbremove.SaveChanges();
                    dbremove.Dispose();
                    MessageBox.Show("Удаление прошло успешно", "Выполнено");
                    _position = null;
                    GetPos();
                }
                else
                {
                    MessageBox.Show("Выберите строку", "Внимание");
                }
            }
        }
        private void MainGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (MainGrid.SelectedValue != null)
                {
                    positions pos = MainGrid.SelectedValue as positions;
                    if (pos == null) return;

                    _position = pos;
                }
        }
    }
}
