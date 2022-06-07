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

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"E:\4 курс\Диплом\Страховка\Insurance\Insurance\лого.jpg"));
            myBrush.ImageSource = image.Source;
            mainGrid.Background = myBrush;
        }

        private void Positions_Click(object sender, RoutedEventArgs e)
        {
            PositionWindow pw = new PositionWindow();
            pw.ShowDialog();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow ew = new EmployeeWindow();
            ew.ShowDialog();
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow cw = new ClientWindow();
            cw.ShowDialog();
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Insurance_Click(object sender, RoutedEventArgs e)
        {
            WindowInsurance wi = new WindowInsurance();
            wi.ShowDialog();
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.ShowDialog();
        }

        private void Insurance_Calc_Click(object sender, RoutedEventArgs e)
        {
            InsuranceCalcAdmin ica = new InsuranceCalcAdmin();
            ica.ShowDialog();
        }

        //private void Insur_cal_Click(object sender, RoutedEventArgs e)
        //{
        //    InsuranceCalcWindow icw = new InsuranceCalcWindow();
        //    icw.ShowDialog();
        //}
    }
}
