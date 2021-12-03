using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            Update_Widok();
        }
        //deklaracja obiektów poszcególnych osób
        public class Uczen {

            public string Rodzaj = "U";

            public string Imie = "";
            public string DrugieImie = "";
            public string Nazwisko = "";
            public string NazwiskoPaniejskie = "";
            public string ImieOjca = "";
            public string ImieMatki = "";
            public string DataUrodzenia = "";
            public string Pesel = "";
            public string Plec = "";
            public string Zdjecie = "";

            public string Klasa = "";
            public string Grupy = "";

            public string ReturnForSave()
            {
                string Temp="";
                Temp = Temp + Rodzaj + "Ø";
                Temp = Temp + Imie + "Ø";
                Temp = Temp + Nazwisko + "Ø";
                Temp = Temp + NazwiskoPaniejskie + "Ø";
                Temp = Temp + ImieOjca + "Ø";
                Temp = Temp + ImieMatki + "Ø";
                Temp = Temp + DataUrodzenia + "Ø";
                Temp = Temp + Pesel + "Ø";
                Temp = Temp + Plec + "Ø";
                Temp = Temp + Klasa + "Ø";
                Temp = Temp + Grupy + "Ø";
                return Temp;
            }
        }
        public class Nauczyciel
        {

            public string Rodzaj = "N";

            public string Imie = "";
            public string DrugieImie = "";
            public string Nazwisko = "";
            public string NazwiskoPaniejskie = "";
            public string ImieOjca = "";
            public string ImieMatki = "";
            public string DataUrodzenia = "";
            public string Pesel = "";
            public string Plec = "";
            public string Zdjecie = "";

            public string WychowawcaKlasa = "";
            public string PrzedmiotyNauczane = "";
            public string Zajecia = "";
            public string DataZatrudnienia = "";

            public string ReturnForSave()
            {
                string Temp = "";
                Temp = Temp + Rodzaj + "Ø";
                Temp = Temp + Imie + "Ø";
                Temp = Temp + Nazwisko + "Ø";
                Temp = Temp + NazwiskoPaniejskie + "Ø";
                Temp = Temp + ImieOjca + "Ø";
                Temp = Temp + ImieMatki + "Ø";
                Temp = Temp + DataUrodzenia + "Ø";
                Temp = Temp + Pesel + "Ø";
                Temp = Temp + Plec + "Ø";
                Temp = Temp + WychowawcaKlasa + "Ø";
                Temp = Temp + PrzedmiotyNauczane + "Ø";
                Temp = Temp + Zajecia + "Ø";
                Temp = Temp + DataZatrudnienia + "Ø";
                return Temp;
            }
        }
        public class Pracownik
        {
            public string Rodzaj = "P";

            public string Imie = "";
            public string DrugieImie = "";
            public string Nazwisko = "";
            public string NazwiskoPaniejskie = "";
            public string ImieOjca = "";
            public string ImieMatki = "";
            public string DataUrodzenia = "";
            public string Pesel = "";
            public string Plec = "";
            public string Zdjecie = "";

            public string Etat = "";
            public string Opis = "";
            public string DataZatrudnienia = "";

            public string ReturnForSave()
            {
                string Temp = "";
                Temp = Temp + Rodzaj + "Ø";
                Temp = Temp + Imie + "Ø";
                Temp = Temp + Nazwisko + "Ø";
                Temp = Temp + NazwiskoPaniejskie + "Ø";
                Temp = Temp + ImieOjca + "Ø";
                Temp = Temp + ImieMatki + "Ø";
                Temp = Temp + DataUrodzenia + "Ø";
                Temp = Temp + Pesel + "Ø";
                Temp = Temp + Plec + "Ø";
                Temp = Temp + Etat + "Ø";
                Temp = Temp + Opis + "Ø";
                Temp = Temp + DataZatrudnienia + "Ø";
                return Temp;
            }
        }

        string UczenWybraneZdjecie = "";
        string NauczycielWybraneZdjecie = "";
        string PracownikWybraneZdjecie = "";

        //Tworzenie 3 table które składają się na "baze", są narazie puste poniewaz potem dane są dodawane funkcją .concat
        Uczen[] TableUczen = new Uczen[0];
        Nauczyciel[] TableNauczyciel = new Nauczyciel[0];
        Pracownik[] TablePracownik = new Pracownik[0];

        //Uaktualnia Widok "Bazy"
        public void Update_Widok()
        {
            Tab_Item_Widok_TextBox.Text = "";
            if (TableUczen.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text+ "Brak rekordów Uczniów\n"; };
            for (int i = 0; i < TableUczen.Length; i++) { 
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TableUczen[i].Imie +" " + TableUczen[i].DrugieImie + " " + TableUczen[i].Nazwisko + " " + TableUczen[i].NazwiskoPaniejskie + " " + TableUczen[i].ImieOjca + " " + TableUczen[i].ImieMatki + " " + TableUczen[i].DataUrodzenia + " " + TableUczen[i].Pesel + " " + TableUczen[i].Plec + " " + TableUczen[i].Klasa + " " + TableUczen[i].Grupy + "\n";
            }
            if (TableNauczyciel.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text+"Brak rekordów Nauczycieli\n"; };
            for (int i = 0; i < TableNauczyciel.Length; i++)
            {
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TableNauczyciel[i].Imie + " " + TableNauczyciel[i].DrugieImie + " " + TableNauczyciel[i].Nazwisko + " " + TableNauczyciel[i].NazwiskoPaniejskie + " " + TableNauczyciel[i].ImieOjca + " " + TableNauczyciel[i].ImieMatki + " " + TableNauczyciel[i].DataUrodzenia + " " + TableNauczyciel[i].Pesel + " " + TableNauczyciel[i].Plec + " " + TableNauczyciel[i].DataZatrudnienia + " " + TableNauczyciel[i].PrzedmiotyNauczane + " " + TableNauczyciel[i].WychowawcaKlasa + " " + TableNauczyciel[i].Zajecia + "\n";
            }
            if (TablePracownik.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + "Brak rekordów Pracowników\n"; };
            for (int i = 0; i < TablePracownik.Length; i++)
            {
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TablePracownik[i].Imie + " " + TablePracownik[i].DrugieImie + " " + TablePracownik[i].Nazwisko + " " + TablePracownik[i].NazwiskoPaniejskie + " " + TablePracownik[i].ImieOjca + " " + TablePracownik[i].ImieMatki + " " + TablePracownik[i].DataUrodzenia + " " + TablePracownik[i].Pesel + " " + TablePracownik[i].Plec + " " + TablePracownik[i].DataZatrudnienia + " " + TablePracownik[i].Etat + " " + TablePracownik[i].Opis + "\n";
            }
        }    
        private void Uczen_StworzRekord_Click_1(object sender, RoutedEventArgs e)
        {

            //Jeden Wielki Check czy pola się zgadzają
            Uczen_ErrorLabel.Content = "";
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
                Uczen_Imie.Text = "Imie";
                Uczen_DrugieImie.Text = "Drugie Imie";
                Uczen_Nazwisko.Text = "Nazwisko";
                Uczen_NazwiskoPaniejskie.Text = "Nazwisko Paniejskie";
                Uczen_ImieOjca.Text = "Imie Matki";
                Uczen_ImieMatki.Text = "Imie Ojca";
                Uczen_Pesel.Text = "Pesel";
                Uczen_Klasa.Text = "Klasa";
                Uczen_Grupy.Text = "Grupy";
                UczenWybraneZdjecie = "";
                Uczen_PlecM.IsChecked = false;
                Uczen_PlecK.IsChecked = false;
                Uczen_DataUrodzenia.SelectedDate = null;
                Uczen_Zdjecie.Source = null;

                Update_Widok();
            }
        }
        private void Uczen_WyborZdjecia_Click1(object sender, RoutedEventArgs e)
        {
            //Kod Otwierania Obrazu z poprzedniego programu
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == true)
            {
                string selectedFileName = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                Uczen_Zdjecie.Source = bitmap;
                UczenWybraneZdjecie = selectedFileName;
            }
        }
        private void Nauczyciel_StworzRekord_Click(object sender, RoutedEventArgs e)
        {
            //Jeden Wielki Check czy pola się zgadzają
            Nauczyciel_ErrorLabel.Content = "";
            bool Check = true;
            if (Nauczyciel_Imie.Text == " " || Nauczyciel_Imie.Text == "Imie")
            {
                Nauczyciel_Imie.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_Imie.Foreground = Brushes.Black; }
            if (Nauczyciel_Nazwisko.Text == " " || Nauczyciel_Nazwisko.Text == "Nazwisko")
            {
                Nauczyciel_Nazwisko.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_Nazwisko.Foreground = Brushes.Black; }
            if (Nauczyciel_DataUrodzenia.SelectedDate >= DateTime.Now || Nauczyciel_DataUrodzenia.SelectedDate == null)
            {
                Nauczyciel_DataUrodzenia.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_DataUrodzenia.Foreground = Brushes.Black; }
            if (Nauczyciel_Pesel.Text == " " || Nauczyciel_Pesel.Text == "Pesel" || Nauczyciel_Pesel.Text.Length != 11 || Nauczyciel_Pesel.Text.All(char.IsDigit) != true)
            {
                Nauczyciel_Pesel.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_Pesel.Foreground = Brushes.Black; }

            if (Nauczyciel_PlecM.IsChecked == false && Nauczyciel_PlecK.IsChecked == false)
            {
                Nauczyciel_PlecM.Foreground = Brushes.Red;
                Nauczyciel_PlecK.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_PlecM.Foreground = Brushes.Black; Nauczyciel_PlecK.Foreground = Brushes.Black; }

            if (Nauczyciel_DataZatrudnienia.SelectedDate > DateTime.Now || Nauczyciel_DataZatrudnienia.SelectedDate == null)
            {
                Nauczyciel_DataZatrudnienia.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_DataZatrudnienia.Foreground = Brushes.Black; }
            if (Nauczyciel_PrzedmiotyNauczane.Text == " " || Nauczyciel_PrzedmiotyNauczane.Text == "Przedmioty Nauczane")
            {
                Nauczyciel_PrzedmiotyNauczane.Foreground = Brushes.Red;
                Check = false;
            }
            else { Nauczyciel_PrzedmiotyNauczane.Foreground = Brushes.Black; }

            //Wiadomość jesli nie
            if (Check == false)
            {
                Nauczyciel_ErrorLabel.Content = "Brakujące lub niepoprawne dane !!!";
            }
            //Jesli Okej to mozna deklarowac zmienną
            //Deklarowanie tymczasowej zmiennej "Uczen" ktora jest potem dodawana do tablicy i łączona z główną tabelą
            if (Check)
            {
                Nauczyciel_ErrorLabel.Content = "";
                Nauczyciel[] TempTableNauczyciel = new Nauczyciel[1];
                Nauczyciel Temp = new Nauczyciel();
                string Plec = "";
                if (Nauczyciel_PlecM.IsChecked == true) { Plec = "Mężczyzna"; };
                if (Nauczyciel_PlecK.IsChecked == true) { Plec = "Kobieta"; };
                string Data;
                Data = Nauczyciel_DataUrodzenia.ToString();
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Temp.Imie = Nauczyciel_Imie.Text;
                Temp.Nazwisko = Nauczyciel_Nazwisko.Text;
                Temp.DataUrodzenia = Data;
                Temp.Pesel = Nauczyciel_Pesel.Text;
                Temp.Plec = Plec;
                Temp.Zdjecie = NauczycielWybraneZdjecie;
                Temp.PrzedmiotyNauczane = Nauczyciel_PrzedmiotyNauczane.Text;
                Temp.DataZatrudnienia = Nauczyciel_DataZatrudnienia.ToString();

                if (Nauczyciel_DrugieImie.Text == "Drugie Imie") { Temp.DrugieImie = " "; }
                else { Temp.DrugieImie = Nauczyciel_DrugieImie.Text; };

                if (Nauczyciel_NazwiskoPaniejskie.Text == "Nazwisko Paniejskie") { Temp.NazwiskoPaniejskie = " "; }
                else { Temp.NazwiskoPaniejskie = Nauczyciel_NazwiskoPaniejskie.Text; };

                if (Nauczyciel_ImieOjca.Text == "Imie Ojca") { Temp.ImieOjca = " "; }
                else { Temp.ImieOjca = Nauczyciel_ImieOjca.Text; };

                if (Nauczyciel_ImieMatki.Text == "Imie Matki") { Temp.ImieMatki = " "; }
                else { Temp.ImieMatki = Nauczyciel_ImieMatki.Text; };

                if (Nauczyciel_WychowawcaKlasy.Text == "Wychowawca Klasy") { Temp.WychowawcaKlasa = " "; }
                else { Temp.WychowawcaKlasa = Nauczyciel_WychowawcaKlasy.Text; };
                if (Nauczyciel_Zajecia.Text == "Zajecia z klasami") { Temp.Zajecia = " "; }
                else { Temp.Zajecia = Nauczyciel_Zajecia.Text; };

                //Łączenie tymczasowej tabeli z tabelą z "bazy danych"
                TempTableNauczyciel[0] = Temp;
                TableNauczyciel = TableNauczyciel.Concat(TempTableNauczyciel).ToArray();

                //Wyczyszczenie Pól tekstowych i powiadomienie uzytkownika
                Nauczyciel_ErrorLabel.Content = "Pomyślnie stworzono";
                Nauczyciel_Imie.Text = "Imie";
                Nauczyciel_DrugieImie.Text = "Drugie Imie";
                Nauczyciel_Nazwisko.Text = "Nazwisko";
                Nauczyciel_NazwiskoPaniejskie.Text = "Nazwisko Paniejskie";
                Nauczyciel_ImieOjca.Text = "Imie Matki";
                Nauczyciel_ImieMatki.Text = "Imie Ojca";
                Nauczyciel_Pesel.Text = "Pesel";
                NauczycielWybraneZdjecie = "";
                Nauczyciel_Zajecia.Text = "Zajecia z klasami";
                Nauczyciel_WychowawcaKlasy.Text = "Wychowawca Klasy";
                Nauczyciel_PrzedmiotyNauczane.Text = "Przedmioty Nauczane";
                Nauczyciel_DataZatrudnienia.SelectedDate = null;
                Nauczyciel_PlecM.IsChecked = false;
                Nauczyciel_PlecK.IsChecked = false;
                Nauczyciel_DataUrodzenia.SelectedDate = null;
                Nauczyciel_Zdjecia.Source = null;

                Update_Widok();
            }
     
        }

        private void Nauczyciel_WyborZdjecia_Click(object sender, RoutedEventArgs e)
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
            Nauczyciel_Zdjecia.Source = bitmap;
            NauczycielWybraneZdjecie = selectedFileName;
        }
        private void Pracownik_StworzRekord_Click1(object sender, RoutedEventArgs e)
        {
            //Jeden Wielki Check czy pola się zgadzają
            Pracownik_ErrorLabel.Content = "";
            bool Check = true;
            if (Pracownik_Imie.Text == " " || Pracownik_Imie.Text == "Imie")
            {
                Pracownik_Imie.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_Imie.Foreground = Brushes.Black; }
            if (Pracownik_Nazwisko.Text == " " || Pracownik_Nazwisko.Text == "Nazwisko")
            {
                Pracownik_Nazwisko.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_Nazwisko.Foreground = Brushes.Black; }
            if (Pracownik_DataUrodzenia.SelectedDate >= DateTime.Now || Pracownik_DataUrodzenia.SelectedDate == null)
            {
                Pracownik_DataUrodzenia.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_DataUrodzenia.Foreground = Brushes.Black; }
            if (Pracownik_Pesel.Text == " " || Pracownik_Pesel.Text == "Pesel" || Pracownik_Pesel.Text.Length != 11 || Pracownik_Pesel.Text.All(char.IsDigit) != true)
            {
                Pracownik_Pesel.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_Pesel.Foreground = Brushes.Black; }

            if (Pracownik_PlecM.IsChecked == false && Pracownik_PlecK.IsChecked == false)
            {
                Pracownik_PlecM.Foreground = Brushes.Red;
                Pracownik_PlecK.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_PlecM.Foreground = Brushes.Black; Pracownik_PlecK.Foreground = Brushes.Black; }

            if (Pracownik_DataZatrudnienia.SelectedDate > DateTime.Now || Pracownik_DataZatrudnienia.SelectedDate == null)
            {
                Pracownik_DataZatrudnienia.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_DataZatrudnienia.Foreground = Brushes.Black; }
            if (Pracownik_Etat.Text == " " || Pracownik_Etat.Text == "Etat")
            {
                Pracownik_Etat.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_Etat.Foreground = Brushes.Black; }
            if (Pracownik_Opis.Text == " " || Pracownik_Opis.Text == "Opis")
            {
                Pracownik_Opis.Foreground = Brushes.Red;
                Check = false;
            }
            else { Pracownik_Opis.Foreground = Brushes.Black; }

            //Wiadomość jesli nie
            if (Check == false)
            {
                Pracownik_ErrorLabel.Content = "Brakujące lub niepoprawne dane !!!";
            }
            //Jesli Okej to mozna deklarowac zmienną
            //Deklarowanie tymczasowej zmiennej "Uczen" ktora jest potem dodawana do tablicy i łączona z główną tabelą
            if (Check)
            {
                Pracownik_ErrorLabel.Content = "";
                Pracownik[] TempTablePracownik = new Pracownik[1];
                Pracownik Temp = new Pracownik();
                string Plec = "";
                if (Pracownik_PlecM.IsChecked == true) { Plec = "Mężczyzna"; };
                if (Pracownik_PlecK.IsChecked == true) { Plec = "Kobieta"; };
                string Data;
                Data = Nauczyciel_DataUrodzenia.ToString();
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Temp.Imie = Pracownik_Imie.Text;
                Temp.Nazwisko = Pracownik_Nazwisko.Text;
                Temp.DataUrodzenia = Data;
                Temp.Pesel = Pracownik_Pesel.Text;
                Temp.Plec = Plec;
                Temp.Zdjecie = PracownikWybraneZdjecie;
                Temp.Opis = Pracownik_Opis.Text;
                Temp.Etat = Pracownik_Etat.Text;
                Temp.DataZatrudnienia = Pracownik_DataZatrudnienia.ToString();

                if (Pracownik_DrugieImie.Text == "Drugie Imie") { Temp.DrugieImie = " "; }
                else { Temp.DrugieImie = Pracownik_DrugieImie.Text; };

                if (Pracownik_NazwiskoPaniejskie.Text == "Nazwisko Paniejskie") { Temp.NazwiskoPaniejskie = " "; }
                else { Temp.NazwiskoPaniejskie = Pracownik_NazwiskoPaniejskie.Text; };

                if (Pracownik_ImieOjca.Text == "Imie Ojca") { Temp.ImieOjca = " "; }
                else { Temp.ImieOjca = Pracownik_ImieOjca.Text; };

                if (Pracownik_ImieMatki.Text == "Imie Matki") { Temp.ImieMatki = " "; }
                else { Temp.ImieMatki = Pracownik_ImieMatki.Text; };

                //Łączenie tymczasowej tabeli z tabelą z "bazy danych"
                TempTablePracownik[0] = Temp;
                TablePracownik = TablePracownik.Concat(TempTablePracownik).ToArray();

                //Wyczyszczenie Pól tekstowych i powiadomienie uzytkownika
                Pracownik_ErrorLabel.Content = "Pomyślnie stworzono";
                Pracownik_Imie.Text = "Imie";
                Pracownik_DrugieImie.Text = "Drugie Imie";
                Pracownik_Nazwisko.Text = "Nazwisko";
                Pracownik_NazwiskoPaniejskie.Text = "Nazwisko Paniejskie";
                Pracownik_ImieOjca.Text = "Imie Matki";
                Pracownik_ImieMatki.Text = "Imie Ojca";
                Pracownik_Pesel.Text = "Pesel";
                PracownikWybraneZdjecie = "";
                Pracownik_Opis.Text = "Opis";
                Pracownik_Etat.Text = "Etat";
                Pracownik_DataZatrudnienia.SelectedDate = null;
                Pracownik_PlecM.IsChecked = false;
                Pracownik_PlecK.IsChecked = false;
                Pracownik_DataUrodzenia.SelectedDate = null;
                Pracownik_Zdjecia.Source = null;

                Update_Widok();
            }
        }
        private void Pracownik_WyborZdjecia_Click(object sender, RoutedEventArgs e)
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
            Pracownik_Zdjecia.Source = bitmap;
            PracownikWybraneZdjecie = selectedFileName;
        }

        private void Plik_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog Zapis = new SaveFileDialog();

            Zapis.Filter = "txt files (*.txt)|*.txt";
            Zapis.FilterIndex = 2;
            Zapis.RestoreDirectory = true;
            if (Zapis.ShowDialog() == true)
            {
                using(StreamWriter writer = new StreamWriter(Zapis.FileName))
                {
                    for (int i = 0; i < TableUczen.Length; i++)
                    {
                        writer.WriteLine(TableUczen[i].ReturnForSave());
                    }
                    for (int i = 0; i < TableNauczyciel.Length; i++)
                    {
                        writer.WriteLine(TableNauczyciel[i].ReturnForSave());
                    }
                    for (int i = 0; i < TablePracownik.Length; i++)
                    {
                        writer.WriteLine(TablePracownik[i].ReturnForSave());
                    }
                    writer.Close();
                }

            }
        }
    }
    }
