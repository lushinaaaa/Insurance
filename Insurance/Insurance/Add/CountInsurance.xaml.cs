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

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для CountInsurance.xaml
    /// </summary>
    public partial class CountInsurance : Window
    {
        InsuranceEntities db => new InsuranceEntities();
        Action<insurance_calc> SaveAction;
        public CountInsurance(Action<insurance_calc> saveAction, Int32? calcId = null)
        {
            InitializeComponent();
            SaveAction = saveAction;

            if (calcId != null)
            {
                insurance_calc calc = db.insurance_calc.First(c => c.id == calcId);

                TB.Text = calc.tb;
                KT.Text = calc.kt;
                KBM.Text = calc.kbm;
                KVS.Text = calc.kvs;
                KO.Text = calc.ko;
                KM.Text = calc.km;
                KS.Text = calc.ks;
                Done.Text = calc.total;
            }
           
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KT_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KBM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KBM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KVS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KVS_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KO_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KO_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void KS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KS_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Done_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Done_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                insurance_calc insurcalcul = new insurance_calc
            {
                tb = TB.Text,
                kt = KT.Text,
                kbm = KBM.Text,
                kvs = KVS.Text,
                ko = KO.Text,
                km = KM.Text,
                ks = KS.Text,
                total = Done.Text
            };

                SaveAction(insurcalcul);
            MessageBox.Show("Стоимость задана!");
            this.Close();
            }
            
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            double done = double.Parse(TB.Text) * double.Parse(KT.Text) * double.Parse(KBM.Text) * double.Parse(KVS.Text) * double.Parse(KO.Text) * double.Parse(KM.Text) * double.Parse(KS.Text);
            Done.Text = Convert.ToString(done);
        }
    }
}
