using Microsoft.Win32;
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
        public class Uczen{

            public string Rodzaj = "U";

            public string Imie = "";
            public string DrugieImie = "";
            public string Nazwisko = "";
            public string NazwiskoPaniejskie = "";
            public string ImieOjca = "";
            public string ImieMatki = "";
            public string DataUrodzenia;
            public string Pesel = "";
            public string Plec = "";
            public string Zdjecie = "";

            public string Klasa = "";
            public string Grupy = "";
        }
        string UczenWybraneZdjecie="";
        //Tworzenie 3 table które składają się na baze, są narazie puste poniewaz potem dane są dodawane funkcją .concat
        Uczen[] TableUczen = new Uczen[0];
        //Nauczyciel[] TableUczen = new Nauczyciel[0];
        //Pracownik[] TableUczen = new Pracownik[0];
        private void Uczen_StworzRekord_Click_1(object sender, RoutedEventArgs e)
        {

            //Jeden Wielki Check czy pola się zgadzają
            Uczen_ErrorLabel.Content = "fgdfgdfg";
            bool Check = true;
            if (Uczen_Imie.Text == " " || Uczen_Imie.Text == "Imie")
            {
                Uczen_Imie.Foreground = Brushes.Red;
                Check = false;
            }
            else { Uczen_Imie.Foreground = Brushes.Black; }
            if (Uczen_Nazwisko.Text == " " || Uczen_Nazwisko.Text == "Nazwisko")
            {
                Uczen_Nazwisko.Foreground = Brushes.Red;
                Check = false;
            }
            else { Uczen_Nazwisko.Foreground = Brushes.Black; }
            if (Uczen_DataUrodzenia.SelectedDate >= DateTime.Now || Uczen_DataUrodzenia.SelectedDate == null)
            {
                Uczen_DataUrodzenia.Foreground = Brushes.Red;
                Check = false;
            }
            else { Uczen_DataUrodzenia.Foreground = Brushes.Black; }
            if (Uczen_Pesel.Text == " " || Uczen_Pesel.Text == "Pesel" || Uczen_Pesel.Text.Length != 11 || Uczen_Pesel.Text.All(char.IsDigit)!=true)
            {
                Uczen_Pesel.Foreground = Brushes.Red;
                Check = false;
            }
            else { Uczen_Pesel.Foreground = Brushes.Black; }

            if (Uczen_PlecM.IsChecked == false && Uczen_PlecK.IsChecked == false)
            {
                Uczen_PlecM.Foreground = Brushes.Red;
                Uczen_PlecK.Foreground = Brushes.Red;
                Check = false;
            }
            else {Uczen_PlecM.Foreground = Brushes.Black;Uczen_PlecK.Foreground = Brushes.Black;}

            if (Uczen_Klasa.Text == " " || Uczen_Klasa.Text == "Klasa")
            {
                Uczen_Klasa.Foreground = Brushes.Red;
                Check = false;
            }
            else { Uczen_Klasa.Foreground = Brushes.Black; }
            //Wiadomość jesli nie
            if (Check == false)
            {
                Uczen_ErrorLabel.Content = "Brakujące lub niepoprawne dane !!!";
            }
            //Jesli Okej to mozna deklarowac zmienną
            //Deklarowanie tymczasowej zmiennej "Uczen" ktora jest potem dodawana do tablicy i łączona z główną tabelą
            if (Check)
            {
                Uczen_ErrorLabel.Content = "";
                Uczen[] TempTableUczen = new Uczen[1];
                Uczen Temp = new Uczen();
                string Plec = "";
                if (Uczen_PlecM.IsChecked==true) { Plec = "Mężczyzna"; };
                if (Uczen_PlecK.IsChecked == true) { Plec = "Kobieta"; };
                string Data;
                Data = Uczen_DataUrodzenia.ToString();
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Temp.Imie = Uczen_Imie.Text;
                Temp.Nazwisko = Uczen_Nazwisko.Text;
                Temp.DataUrodzenia = Data;
                Temp.Pesel = Uczen_Pesel.Text;
                Temp.Plec = Plec;
                Temp.Klasa = Uczen_Klasa.Text;
                Temp.Zdjecie = UczenWybraneZdjecie;

                if (Uczen_DrugieImie.Text=="Drugie Imie") { Temp.DrugieImie = " "; } 
                else { Temp.DrugieImie = Uczen_DrugieImie.Text; };

                if (Uczen_NazwiskoPaniejskie.Text == "Nazwisko Paniejskie") { Temp.NazwiskoPaniejskie = " "; }
                else { Temp.NazwiskoPaniejskie = Uczen_NazwiskoPaniejskie.Text; };

                if (Uczen_ImieOjca.Text == "Imie Ojca") { Temp.ImieOjca = " "; }
                else { Temp.ImieOjca = Uczen_ImieOjca.Text; };

                if (Uczen_ImieMatki.Text == "Imie Matki") { Temp.ImieMatki = " "; }
                else { Temp.ImieMatki = Uczen_ImieMatki.Text; };

                if (Uczen_Grupy.Text == "Grupy") { Temp.Grupy = " "; }
                else { Temp.Grupy = Uczen_Grupy.Text; };

                //Łączenie tymczasowej tabeli z tabelą z "bazy danych"
                TempTableUczen[0] = Temp;
                TableUczen = TableUczen.Concat(TempTableUczen).ToArray();

                //Wyczyszczenie Pól tekstowych i powiadomienie uzytkownika
                Uczen_ErrorLabel.Content = "Pomyślnie stworzono";
                Uczen_Imie.Text = "";
                Uczen_DrugieImie.Text = "";
                Uczen_Nazwisko.Text = "";
                Uczen_NazwiskoPaniejskie.Text = "";
                Uczen_ImieOjca.Text = "";
                Uczen_ImieMatki.Text = "";
                Uczen_Pesel.Text = "";
                Uczen_Klasa.Text = "";
                Uczen_Grupy.Text = "";
                UczenWybraneZdjecie = "";
                Uczen_PlecM.IsChecked = false;
                Uczen_PlecK.IsChecked = false;
                Uczen_DataUrodzenia.SelectedDate = null;
            }
        }
        private void Uczen_WyborZdjecia_Click(object sender, RoutedEventArgs e)
        {
            //Kod Otwierania Obrazu z poprzedniego programu
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            dlg.ShowDialog();

            string selectedFileName = dlg.FileName;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(selectedFileName);
            bitmap.EndInit();
            Uczen_Zdjecie.Source = bitmap;
            UczenWybraneZdjecie = selectedFileName;
        }
    }
}
