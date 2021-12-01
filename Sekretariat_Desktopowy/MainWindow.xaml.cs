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

namespace Sekretariat_Desktopowy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*public class Uczen{
            string Imie="";
            string DrugieImie = "";
            string Nazwisko = "";
            string NazwiskoPaniejskie = "";
            DateTime DataUrodzenia;
            string Pesel = "";
            string Plec = "";
            string Zdjecie = "";

            string Klasa = "";
            string Grupy = "";
        }*/

        private void Uczen_StworzRekord_Click(object sender, RoutedEventArgs e)
        {
            Uczen_ErrorLabel.Content = "fgdfgdfg";
            bool Check=true;
            if (Uczen_Imie.Text == " " || Uczen_Imie.Text == "Imie")
            {
                Uczen_Imie.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_Nazwisko.Text == " " || Uczen_Nazwisko.Text == "Nazwisko")
            {
                Uczen_Imie.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_DataUrodzenia.SelectedDate>=DateTime.Now || Uczen_DataUrodzenia.SelectedDate==null)
            {
                Uczen_DataUrodzenia.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_Pesel.Text == " " || Uczen_Pesel.Text == "Pesel" || Uczen_Pesel.Text.Length!=11)
            {
                Uczen_Pesel.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_PlecM.IsChecked==false || Uczen_PlecK.IsChecked == false)
            {
                Uczen_PlecM.Foreground = Brushes.Red;
                Uczen_PlecK.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_Klasa.Text == " " || Uczen_Klasa.Text == "Klasa")
            {
                Uczen_Klasa.Foreground = Brushes.Red;
                Check = false;
            }

            if (Check == false)
            {
                Uczen_ErrorLabel.Content = "Brakujące lub nie poprawne dane !!!";
            }
            else
            {
                Uczen_ErrorLabel.Content = "";
            }

        }

        private void Nauczyciel_StworzRekord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pracownik_StworzRekord_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
