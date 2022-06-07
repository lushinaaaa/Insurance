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
using Microsoft.Win32;

namespace Insurance
{
    /// <summary>
    /// Логика взаимодействия для WindowInsurance.xaml
    /// </summary>
    /// 

    public partial class WindowInsurance : Window
    {
        private insurance _insurance;
        InsuranceEntities db => new InsuranceEntities();
        public static List<positions> items { get; set; } = new List<positions>();
        employees Agent = null;

        public WindowInsurance(employees emp = null)
        {
            InitializeComponent();
            
            if (emp != null)
            {
                Empl.Visibility = Visibility.Hidden;
                All.IsEnabled = false;
                Check.IsEnabled = false;
                Agent = emp;
            }

            GetInsur();

            List<employees> empl = db.employees.ToList();
            employees all = new employees { id = -1 };
            empl = empl.ToList();
            Empl.ItemsSource = empl;
            Empl.SelectedIndex = 0;

        }

        
        void filter(employees value)
        {
            if (value.id == -1)
            {
                GetInsur();
            }
            else
            {

                injuredGrid.ItemsSource = null;
                injuredGrid.Items.Refresh();
                var query = db.insurance.Where(a => a.employees.id == value.id).ToArray();
                injuredGrid.ItemsSource = query.ToList();
            }
        }

            public void GetInsur()
            {
                injuredGrid.ItemsSource = null;
                injuredGrid.Items.Refresh();
                var query = db.insurance.ToArray();
                if (Agent != null)
                {
                    query = query.Where(i => i.id_employee == Agent.id).ToArray();
                }
                injuredGrid.ItemsSource = query.ToList();
            }

            private void add_Click(object sender, RoutedEventArgs e)
        {
            AddInsurance ai = new AddInsurance(GetInsur);
            ai.ShowDialog();
        }


        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (_insurance != null)
            {
                InsuranceEntities dbremove = new InsuranceEntities();
                insurance pr = dbremove.insurance
                   .Where(o => o.id == _insurance.id)
                   .FirstOrDefault();
                dbremove.insurance.Remove(pr);
                dbremove.SaveChanges();
                dbremove.Dispose();
                MessageBox.Show("Удаление прошло успешно", "Выполнено");
                _insurance = null;
                GetInsur();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "PDF Files | *.pdf";
            //if (sfd.ShowDialog() == false) return;

            //iTextSharp.text.Document doc = new iTextSharp.text.Document();
            //PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.OpenOrCreate));
            //doc.Open();
            //BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            //PdfPTable table = new PdfPTable(11);
            //PdfPCell cell = new PdfPCell(new Phrase("Страховка", font));
            ////cell.Colspan = 5;
            ////cell.HorizontalAlignment = 1;
            //////Убираем границу первой ячейки, чтобы было как заголовок
            ////cell.Border = 0;
            ////table.AddCell(cell);
            ////cell = new PdfPCell(new Phrase("   ", font));
            ////table.AddCell(cell);
            ////cell = new PdfPCell(new Phrase("   ", font));
            ////cell.Colspan = 5;
            ////table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("ID", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Серия страхового полиса", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Срок страхования с ", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("по", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("ID клиента", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Собственник автомобиля", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Модель автомобиля", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Идентификационный номер ТС", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Государственный регистрационный номер ТС", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("ID Стоимости страховки", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("ID_сотрудника", font));
            ////Фоновый цвет (необязательно, просто сделаем по красивее)
            //cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            //table.AddCell(cell);
            //List<insurance> projects = (from p in db.insurance select p).ToList<insurance>();
            //for (int j = 0; j < projects.Count; j++)
            //{
            //    insurance p = new insurance();
            //    p = projects[j];
            //    table.AddCell(new Phrase(p.id.ToString(), font));
            //    table.AddCell(new Phrase(p.insurence.ToString(), font));
            //    table.AddCell(new Phrase(p.start_date.ToString(), font));
            //    table.AddCell(new Phrase(p.end_date.ToString(), font));
            //    table.AddCell(new Phrase(p.id_client.ToString(), font));
            //    table.AddCell(new Phrase(p.car_owner.ToString(), font));
            //    table.AddCell(new Phrase(p.car_model.ToString(), font));
            //    table.AddCell(new Phrase(p.identification_number.ToString(), font));
            //    table.AddCell(new Phrase(p.registration_number.ToString(), font));
            //    table.AddCell(new Phrase(p.id_calculation.ToString(), font));
            //    table.AddCell(new Phrase(p.id_employee.ToString(), font));
            //}
            ////Добавляем таблицу в документ
            //doc.Add(table);
            //doc.Close(); MessageBox.Show("Pdf-документ сохранен");

            if (_insurance != null)
            {
                InsurancePdf.PrintPdf(_insurance);
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }

        private void FNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            String text = fNameBox.Text.ToLower();

            var query = db.insurance.ToList();
            injuredGrid.ItemsSource = query;

            insurance[] insurances = db.insurance
                .Where(x => x.car_owner.ToLower().StartsWith(text) || x.registration_number.ToLower().StartsWith(text)).ToArray();

            injuredGrid.ItemsSource = null;
            injuredGrid.ItemsSource = insurances;
        }

        private void FNameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Empl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filter(Empl.SelectedItem as employees);
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (_insurance != null)
            {
                AddInsurance window = new AddInsurance(GetInsur, _insurance);
                window.ShowDialog();
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
                insurance emp = injuredGrid.SelectedValue as insurance;
                if (emp == null) return;

                _insurance = emp;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            //CountInsurance ci = new CountInsurance();
            //ci.ShowDialog();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (_insurance != null)
            {
                MyPdfWriter.PrintPdf(_insurance);
            }
            else
            {
                MessageBox.Show("Выберите строку", "Внимание");
            }
        }
    }
}
