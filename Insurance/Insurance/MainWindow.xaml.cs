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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Insurance.Model;


namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InsuranceEntities db = new InsuranceEntities();

        public MainWindow()
        {
            InitializeComponent();
            App.Current.Dispatcher.UnhandledException += ExceptionHandler;
        }

        private void ExceptionHandler(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            App.ShowMessage("Произошла неизвестная ошибка");
            e.Handled = true;
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {

            if(String.IsNullOrEmpty(loginBox.Text) || String.IsNullOrEmpty(passwordBox.Password))
            {
                MessageBox.Show("Ошибка! Одно или оба поля пустые!");
                return;
            }

            users user = db.users.Where(x => x.login == loginBox.Text && x.password == passwordBox.Password).SingleOrDefault();
            
            if(user == null)
            {
                MessageBox.Show("Логин или пароль неверны!");
                return;
            }

            switch (Enum.Parse(typeof(Role), user.role.ToString()))
            {
                case Role.admin:

                WindowData wd1 = new WindowData();
                    loginBox.Clear();
                    passwordBox.Clear();
                    wd1.ShowDialog();
                    break;

                //case Role.buh:

                //    WindowData wd2 = new WindowData();
                //    this.Close();
                //    wd2.ShowDialog();
                //    break;

                case Role.agent1:

                    WindowDataAgent wd2 = new WindowDataAgent(user.employees);
                    loginBox.Clear();
                    passwordBox.Clear();
                    wd2.ShowDialog();
                    break;

                    //case Role.agent2:

                    //    WindowData wd4 = new WindowData();
                    //    this.Close();
                    //    wd4.ShowDialog();
                    //    break;
            }
        }
    }
}
