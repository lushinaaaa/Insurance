//using Insurance.Models;
//using Insurance_App.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public static WindowData wd;
        //public static Model.u;
        //public static ElementWindow ew;
        //public static HumanWindow hw;
        //public static AffectedWindow aw;
        //public static reportWindow rw;
        //public static panelAdminWindow paw;
        //public static typesWindow tw;

        public static void NumberBox_PreviewTextInput(TextCompositionEventArgs e)
        {
            if (e.Text.Length == 1)
            {
                if (Char.IsDigit(Convert.ToChar(e.Text)))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }
        public static void LetterBox_PreviewTextInput(TextCompositionEventArgs e)
        {
            if (e.Text.Length == 1)
            {
                if (Char.IsLetter(Convert.ToChar(e.Text)))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }
        public static void LetterOrDigitBox_PreviewTextInput(TextCompositionEventArgs e)
        {
            if (e.Text.Length == 1)
            {
                if (Char.IsLetterOrDigit(Convert.ToChar(e.Text)))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }

        public static void ShowMessage(String message, String title = "Сообщение", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.Asterisk)
        {
            MessageBox.Show(message, title, button, image);
        }
    }
}
