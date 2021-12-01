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
            if (Uczen_Nazwisko.Text == " " || Uczen_Nazwisko.Text == "Nazwisko")
            {
                Uczen_Nazwisko.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_DataUrodzenia.SelectedDate >= DateTime.Now || Uczen_DataUrodzenia.SelectedDate == null)
            {
                Uczen_DataUrodzenia.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_Pesel.Text == " " || Uczen_Pesel.Text == "Pesel" || Uczen_Pesel.Text.Length != 11)
            {
                Uczen_Pesel.Foreground = Brushes.Red;
                Check = false;
            }
            if (Uczen_PlecM.IsChecked == false || Uczen_PlecK.IsChecked == false)
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
            //Wiadomość jesli nie
            if (Check == false)
            {
                Uczen_ErrorLabel.Content = "Brakujące lub nie poprawne dane !!!";
            }
            //Jesli Okej to mozna deklarowac zmienną
            //Deklarowanie tymczasowej zmiennej "Uczen" ktora jest potem dodawana do tablicy i łączona z główną tabelą
            if (Check)
            {
                Uczen_ErrorLabel.Content = "";
                Uczen[] TempTableUczen = new Uczen[1];
                string Plec = "";
                if (Uczen_PlecM.IsChecked==true) { Plec = "Mężczyzna"; };
                if (Uczen_PlecK.IsChecked == true) { Plec = "Kobieta"; };
                string Data;
                Data = Uczen_DataUrodzenia.ToString();
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                TempTableUczen[0].Imie = Uczen_Imie.Text;
                TempTableUczen[0].Nazwisko = Uczen_Nazwisko.Text;
                TempTableUczen[0].DataUrodzenia = Data;
                TempTableUczen[0].Pesel = Uczen_Pesel.Text;
                TempTableUczen[0].Plec = Plec;
                TempTableUczen[0].Klasa = Uczen_Klasa.Text;
                TempTableUczen[0].Zdjecie = UczenWybraneZdjecie;

                if (Uczen_DrugieImie.Text=="Drugie Imie") { TempTableUczen[0].DrugieImie = " "; } 
                else { TempTableUczen[0].DrugieImie = Uczen_DrugieImie.Text; };

                if (Uczen_NazwiskoPaniejskie.Text == "Nazwisko Paniejskie") { TempTableUczen[0].NazwiskoPaniejskie = " "; }
                else { TempTableUczen[0].NazwiskoPaniejskie = Uczen_NazwiskoPaniejskie.Text; };

                if (Uczen_ImieOjca.Text == "Imie Ojca") { TempTableUczen[0].ImieOjca = " "; }
                else { TempTableUczen[0].ImieOjca = Uczen_ImieOjca.Text; };

                if (Uczen_ImieMatki.Text == "Imie Matki") { TempTableUczen[0].ImieMatki = " "; }
                else { TempTableUczen[0].ImieMatki = Uczen_ImieMatki.Text; };

                if (Uczen_Grupy.Text == "Grupy") { TempTableUczen[0].Grupy = " "; }
                else { TempTableUczen[0].Grupy = Uczen_Grupy.Text; };

                //Łączenie tymczasowej tabeli z tabelą z "bazy danych"
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
