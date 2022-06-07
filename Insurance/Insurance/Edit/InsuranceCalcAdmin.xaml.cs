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
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Insurance.Model;

namespace Insurance.Edit
{
    /// <summary>
    /// Логика взаимодействия для InsuranceCalcAdmin.xaml
    /// </summary>
    public partial class InsuranceCalcAdmin : Window
    {
        private insurance_calc _insurance_calc;
        InsuranceEntities db => new InsuranceEntities();
        public InsuranceCalcAdmin()
        {
            InitializeComponent();
            GetInsur();
        }

        public void GetInsur()
        {
            injuredGrid.ItemsSource = null;
            injuredGrid.Items.Refresh();
            var query = db.insurance_calc.ToArray();
            injuredGrid.ItemsSource = query.ToList();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (_insurance_calc != null)
            {
                InsuranceEntities dbremove = new InsuranceEntities();
                insurance_calc pr = dbremove.insurance_calc
                   .Where(o => o.id == _insurance_calc.id)
                   .FirstOrDefault();
                dbremove.insurance_calc.Remove(pr);
                dbremove.SaveChanges();
                dbremove.Dispose();
                MessageBox.Show("Удаление прошло успешно", "Выполнено");
                _insurance_calc = null;
                GetInsur();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void InjuredGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (injuredGrid.SelectedValue != null)
            {
                insurance_calc ins = injuredGrid.SelectedValue as insurance_calc;
                if (ins == null) return;

                _insurance_calc = ins;
            }
        }
    }
}
