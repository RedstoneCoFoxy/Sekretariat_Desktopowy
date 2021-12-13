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
            Update_Widok(TableUczen,TableNauczyciel,TablePracownik);
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

                Temp = Temp + DrugieImie + "Ø";
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
            public string ReturnForPrint()
            {
                string Temp = "";
                Temp = Temp + "Imie: " + Imie + " ";
                Temp = Temp + "D.Imie: " + DrugieImie + " ";
                Temp = Temp + "Nazwisko: " + Nazwisko + " ";
                Temp = Temp + "N.Paniejskie: " + NazwiskoPaniejskie + " ";
                Temp = Temp + "I.Ojca: " + ImieOjca + " ";
                Temp = Temp + "I.Matki: " + ImieMatki + " ";
                Temp = Temp + "Data Urodzenia: " + DataUrodzenia + " ";
                Temp = Temp + "Pesel: " + Pesel + " ";
                Temp = Temp + "Plec: " + Plec + " ";
                Temp = Temp + "Klasa: " + Klasa + " ";
                Temp = Temp + "Grupy: " + Grupy + " ";
                Temp = Temp + "\n";
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
                Temp = Temp + DrugieImie + "Ø";
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
            public string ReturnForPrint()
            {
                string Temp = "";
                Temp = Temp + "Imie: " + Imie + " ";
                Temp = Temp + "D.Imie: " + DrugieImie + " ";
                Temp = Temp + "Nazwisko: " + Nazwisko + " ";
                Temp = Temp + "N.Paniejskie: " + NazwiskoPaniejskie + " ";
                Temp = Temp + "I.Ojca: " + ImieOjca + " ";
                Temp = Temp + "I.Matki: " + ImieMatki + " ";
                Temp = Temp + "Data Urodzenia: " + DataUrodzenia + " ";
                Temp = Temp + "Pesel: " + Pesel + " ";
                Temp = Temp + "Plec: " + Plec + " ";
                Temp = Temp + "Wychowawstwo: " + WychowawcaKlasa + " ";
                Temp = Temp + "P. Nauczane: " + PrzedmiotyNauczane + " ";
                Temp = Temp + "Zajecia: " + Zajecia + " ";
                Temp = Temp + "Data Zatrudnienia: " + DataZatrudnienia + " ";
                Temp = Temp + "\n";
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
                Temp = Temp + DrugieImie + "Ø";
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
            public string ReturnForPrint()
            {
                string Temp = "";
                Temp = Temp + "Imie: " + Imie + " ";
                Temp = Temp + "D.Imie: " + DrugieImie + " ";
                Temp = Temp + "Nazwisko: " + Nazwisko + " ";
                Temp = Temp + "N.Paniejskie: " + NazwiskoPaniejskie + " ";
                Temp = Temp + "I.Ojca: " + ImieOjca + " ";
                Temp = Temp + "I.Matki: " + ImieMatki + " ";
                Temp = Temp + "Data Urodzenia: " + DataUrodzenia + " ";
                Temp = Temp + "Pesel: " + Pesel + " ";
                Temp = Temp + "Plec: " + Plec + " ";
                Temp = Temp + "Etat: " + Etat + " ";
                Temp = Temp + "Opis: " + Opis + " ";
                Temp = Temp + "Data Zatrudnienia: " + DataZatrudnienia + " ";
                Temp = Temp + "\n";
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
        public void Update_Widok(Uczen[] TempUczen, Nauczyciel[] TempNauczyciel, Pracownik[] TempPracownik)
        {
            Tab_Item_Widok_TextBox.Text = "";
            if (TempUczen.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text+ "Brak rekordów Uczniów\n"; };
            for (int i = 0; i < TempUczen.Length; i++) {
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TempUczen[i].ReturnForPrint();
            }
            if (TempNauczyciel.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text+"Brak rekordów Nauczycieli\n"; };
            for (int i = 0; i < TempNauczyciel.Length; i++)
            {
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TempNauczyciel[i].ReturnForPrint();
            }
            if (TempPracownik.Length == 0) { Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + "Brak rekordów Pracowników\n"; };
            for (int i = 0; i < TempPracownik.Length; i++)
            {
                Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + TempPracownik[i].ReturnForPrint();
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
                Data = Data.Substring(0, 10);
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

                Update_Widok(TableUczen,TableNauczyciel,TablePracownik);
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
                Data = Uczen_DataUrodzenia.ToString();
                Data = Data.Substring(0, 10);
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Temp.Imie = Nauczyciel_Imie.Text;
                Temp.Nazwisko = Nauczyciel_Nazwisko.Text;
                Temp.DataUrodzenia = Data;
                Temp.Pesel = Nauczyciel_Pesel.Text;
                Temp.Plec = Plec;
                Temp.Zdjecie = NauczycielWybraneZdjecie;
                Temp.PrzedmiotyNauczane = Nauczyciel_PrzedmiotyNauczane.Text;
                Temp.DataZatrudnienia = Nauczyciel_DataZatrudnienia.ToString().Substring(0, 10);

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

                Update_Widok(TableUczen, TableNauczyciel, TablePracownik);
            }
     
        }

        private void Nauczyciel_WyborZdjecia_Click(object sender, RoutedEventArgs e)
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
                Nauczyciel_Zdjecia.Source = bitmap;
                NauczycielWybraneZdjecie = selectedFileName;
            }
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
                Data = Uczen_DataUrodzenia.ToString();
                Data = Data.Substring(0, 10);
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                Temp.Imie = Pracownik_Imie.Text;
                Temp.Nazwisko = Pracownik_Nazwisko.Text;
                Temp.DataUrodzenia = Data;
                Temp.Pesel = Pracownik_Pesel.Text;
                Temp.Plec = Plec;
                Temp.Zdjecie = PracownikWybraneZdjecie;
                Temp.Opis = Pracownik_Opis.Text;
                Temp.Etat = Pracownik_Etat.Text;
                Temp.DataZatrudnienia = Pracownik_DataZatrudnienia.ToString().Substring(0, 10);

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

                Update_Widok(TableUczen, TableNauczyciel, TablePracownik);
            }
        }
        private void Pracownik_WyborZdjecia_Click(object sender, RoutedEventArgs e)
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
                Pracownik_Zdjecia.Source = bitmap;
                PracownikWybraneZdjecie = selectedFileName;
            }
        }

        private void Plik_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog Zapis = new SaveFileDialog();

            Zapis.Filter = "Pliki bazy (*.baza)|*.baza"; //użyłem wlasnego rozszerzenia pliku, żeby użytkownik niemógł się pomylić przy zapisywaniu
            Zapis.FilterIndex = 2;
            Zapis.RestoreDirectory = true;
            if (Zapis.ShowDialog() == true)
            {
                using(StreamWriter writer = new StreamWriter(Zapis.FileName))
                {
                    //każda tabela ma własną funkcje która zwraca rekord o danym indeksie już jako gotowy do zapisu, z poszczególnymi polami oddzielonymi znakiem specjalnym Ø
                    //rozwiązuje to problem gdyby pojawiłby się znak biały w tekście
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
        public void ZaladujRekordDoBazy(string line)
        {
            //wszystkie dzialaja na tej samej zasadzie, roznią się jednyie iloscią pól które muszą prowadzic i do której tabeli
            //najpierw sprawdza do której tabeli idzie U, N, P
            //potem pierwsza czesc od początku do specjalnego znaku ( Ø ), jest wkladana, usuwa ten segment i idzie do następnego i tak az do konća
            if (line.StartsWith("U")){
                Uczen[] TempTableUczen = new Uczen[1];
                Uczen Temp = new Uczen();

                Temp.Rodzaj = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0,line.IndexOf("Ø")+1);

                Temp.Imie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø")+1);

                Temp.DrugieImie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Nazwisko = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.NazwiskoPaniejskie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieOjca = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieMatki = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DataUrodzenia = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Pesel = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Plec = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);


                Temp.Klasa = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Grupy = line.Substring(0, line.Length);

                TempTableUczen[0] = Temp;
                TableUczen = TableUczen.Concat(TempTableUczen).ToArray();
            }
            if (line.StartsWith("N"))
            {
                Nauczyciel[] TempTableNauczyciel = new Nauczyciel[1];
                Nauczyciel Temp = new Nauczyciel();

                Temp.Rodzaj = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Imie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DrugieImie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Nazwisko = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.NazwiskoPaniejskie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieOjca = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieMatki = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DataUrodzenia = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Pesel = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Plec = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.WychowawcaKlasa = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.PrzedmiotyNauczane = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Zajecia = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DataZatrudnienia = line.Substring(0, line.Length);

                TempTableNauczyciel[0] = Temp;
                TableNauczyciel = TableNauczyciel.Concat(TempTableNauczyciel).ToArray();
            }
            if (line.StartsWith("P"))
            {
                Pracownik[] TempTablePracownik = new Pracownik[1];
                Pracownik Temp = new Pracownik();

                Temp.Rodzaj = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Imie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DrugieImie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Nazwisko = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.NazwiskoPaniejskie = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieOjca = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.ImieMatki = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DataUrodzenia = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Pesel = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Plec = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Etat = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.Opis = line.Substring(0, line.IndexOf("Ø"));
                line = line.Remove(0, line.IndexOf("Ø") + 1);

                Temp.DataZatrudnienia = line.Substring(0, line.Length);

                TempTablePracownik[0] = Temp;
                TablePracownik = TablePracownik.Concat(TempTablePracownik).ToArray();
            }
        }
        private void Plik_Wczytaj_Click(object sender, RoutedEventArgs e)
        {
            //zwykle otwieranie pliki
            //swtworzylem wlasne rozszerzenie .baza żeby użytkownik nie mógł otworzyć niepoprawnego pliku
            OpenFileDialog Otworz = new OpenFileDialog();

            Otworz.Filter = "Pliki bazy (*.baza)|*.baza";
            Otworz.FilterIndex = 2;
            Otworz.RestoreDirectory = true;
            if (Otworz.ShowDialog() == true)
            {            
                
                using (StreamReader reader = new StreamReader(Otworz.FileName))
                {
                    Tab_Item_Widok_TextBox.Text = "";
                    string line;
                    TableUczen = new Uczen[0];
                    TableNauczyciel = new Nauczyciel[0];
                    TablePracownik = new Pracownik[0];
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Sprawdzanie czy poszczególna linia w pliku własciwie pasuje do jednej z 3 tabel
                        if (line.StartsWith("U")|| line.StartsWith("N")|| line.StartsWith("P"))
                        {                           
                            ZaladujRekordDoBazy(line); //wywoływanie funkcji która wlaściwie wprowadza rekordy do "Bazy" linia po lini
                            Tab_Item_Widok_TextBox.Text = line;
                        }                       
                    }
                    Update_Widok(TableUczen, TableNauczyciel, TablePracownik);
                    reader.Close();
                }
            }
        }
        private void Plik_Sortuj_Click(object sender, RoutedEventArgs e) //przelaczanie na tab sortowania, chowając inne
        {
            Tab_Item_Sortuj.Visibility = Visibility.Visible;
            Tab_Item_Sortuj.IsSelected = true;

            Tab_Item_Widok.Visibility = Visibility.Hidden;
            Tab_Item_Rekord.Visibility = Visibility.Hidden;
        }     
        private void Sortuj_Wroc_Click(object sender, RoutedEventArgs e)
        {
            Tab_Item_Sortuj.Visibility = Visibility.Hidden;
            Tab_Item_Widok.IsSelected = true;

            Tab_Item_Widok.Visibility = Visibility.Visible;
            Tab_Item_Rekord.Visibility = Visibility.Visible;
        }

        void Sortuj(int Rodzaj, Uczen[] UczenTemp, Nauczyciel[] NauczycielTemp, Pracownik[] PracownikTemp, int WybranePole) //funkcja sortująca 
        {
            if (UczenTemp.Length + NauczycielTemp.Length + PracownikTemp.Length > 0)
            {
                string[] zmienne = new string[0];
                for (int U = 0; U < UczenTemp.Length; U++)
                {
                    string[] temp = new string[1];
                    switch (WybranePole) //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                    {
                        case 0: temp[0] = UczenTemp[U].Imie + U.ToString() + "U"; break;
                        case 1: temp[0] = UczenTemp[U].DrugieImie + U.ToString() + "U"; break;
                        case 2: temp[0] = UczenTemp[U].Nazwisko + U.ToString() + "U"; break;
                        case 3: temp[0] = UczenTemp[U].NazwiskoPaniejskie + U.ToString() + "U"; break;
                        case 4: temp[0] = UczenTemp[U].ImieMatki + U.ToString() + "U"; break;
                        case 5: temp[0] = UczenTemp[U].ImieOjca + U.ToString() + "U"; break;
                        case 6: temp[0] = UczenTemp[U].DataUrodzenia + U.ToString() + "U"; break;
                        case 7: temp[0] = UczenTemp[U].Pesel + U.ToString() + "U"; break;
                        case 8: temp[0] = UczenTemp[U].Plec + U.ToString() + "U"; break;
                        case 9: temp[0] = UczenTemp[U].Klasa + U.ToString() + "U"; break;//klasa
                        case 10: temp[0] = UczenTemp[U].Grupy + U.ToString() + "U"; break;//grupy
                    }
                    zmienne = zmienne.Concat(temp).ToArray();
                }
                for (int U = 0; U < NauczycielTemp.Length; U++)
                {
                    string[] temp = new string[1];
                    switch (WybranePole) //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                    {
                        case 0: temp[0] = NauczycielTemp[U].Imie + U.ToString() + "N"; break;
                        case 1: temp[0] = NauczycielTemp[U].DrugieImie + U.ToString() + "N"; break;
                        case 2: temp[0] = NauczycielTemp[U].Nazwisko + U.ToString() + "N"; break;
                        case 3: temp[0] = NauczycielTemp[U].NazwiskoPaniejskie + U.ToString() + "N"; break;
                        case 4: temp[0] = NauczycielTemp[U].ImieMatki + U.ToString() + "N"; break;
                        case 5: temp[0] = NauczycielTemp[U].ImieOjca + U.ToString() + "N"; break;
                        case 6: temp[0] = NauczycielTemp[U].DataUrodzenia + U.ToString() + "N"; break;
                        case 7: temp[0] = NauczycielTemp[U].Pesel + U.ToString() + "N"; break;
                        case 8: temp[0] = NauczycielTemp[U].Plec + U.ToString() + "N"; break;
                        case 11: temp[0] = NauczycielTemp[U].WychowawcaKlasa + U.ToString() + "N"; break;//Wychowawstwo
                        case 12: temp[0] = NauczycielTemp[U].PrzedmiotyNauczane + U.ToString() + "N"; break;//Przedmioty
                        case 13: temp[0] = NauczycielTemp[U].Zajecia + U.ToString() + "N"; break;//Zajecia
                        case 14: temp[0] = NauczycielTemp[U].DataZatrudnienia + U.ToString() + "N"; break;//DataZatrudnienia
                    }
                    zmienne = zmienne.Concat(temp).ToArray();
                }
                for (int U = 0; U < PracownikTemp.Length; U++)
                {
                    string[] temp = new string[1];
                    switch (WybranePole) //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                    {
                        case 0: temp[0] = PracownikTemp[U].Imie + U.ToString() + "P"; break;
                        case 1: temp[0] = PracownikTemp[U].DrugieImie + U.ToString() + "P"; break;
                        case 2: temp[0] = PracownikTemp[U].Nazwisko + U.ToString() + "P"; break;
                        case 3: temp[0] = PracownikTemp[U].NazwiskoPaniejskie + U.ToString() + "P"; break;
                        case 4: temp[0] = PracownikTemp[U].ImieMatki + U.ToString() + "P"; break;
                        case 5: temp[0] = PracownikTemp[U].ImieOjca + U.ToString() + "P"; break;
                        case 6: temp[0] = PracownikTemp[U].DataUrodzenia + U.ToString() + "P"; break;
                        case 7: temp[0] = PracownikTemp[U].Pesel + U.ToString() + "P"; break;
                        case 8: temp[0] = PracownikTemp[U].Plec + U.ToString() + "P"; break;
                        case 14: temp[0] = PracownikTemp[U].DataZatrudnienia + U.ToString() + "P"; break;//DataZatrudnienia
                        case 15: temp[0] = PracownikTemp[U].Etat + U.ToString() + "P"; break;//Etat
                        case 16: temp[0] = PracownikTemp[U].Opis + U.ToString() + "P"; break;//Opis
                    }
                    zmienne = zmienne.Concat(temp).ToArray();
                }

                Array.Sort(zmienne); //Gdy znalazlem tą funkcje, wpadłem na rozwiązanie
                if (Sortuj_RadioMalejaco.IsChecked == true)
                {
                    zmienne = zmienne.Reverse().ToArray();
                }
                Tab_Item_Widok_TextBox.Text = "";
                for (int U = 0; U < zmienne.Length; U++)
                {
                    //W tej częsci jest dekodowanie i wypisywanie
                    //2 ostatnie znaki, które zostały dodane wczesniej przed sortowaniem
                    //są teraz sprawdzane, i jesli jest U to Uczen, N dla Nauczyciela, P Pracownik
                    //Potem jest sprawdzana lizba, czy pod tym indexem jest wlasciwie ten rekord                      
                    string String = zmienne[U];
                    if (String.EndsWith("U"))
                    {
                        int i = Int32.Parse(String.Substring(String.Length - 2, 1));
                        //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                        switch (WybranePole)
                        {
                            case 0:
                                if (UczenTemp[i].Imie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 1:
                                if (UczenTemp[i].DrugieImie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 2:
                                if (UczenTemp[i].Nazwisko.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 3:
                                if (UczenTemp[i].NazwiskoPaniejskie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 4:
                                if (UczenTemp[i].ImieMatki.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 5:
                                if (UczenTemp[i].ImieOjca.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 6:
                                if (UczenTemp[i].DataUrodzenia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 7:
                                if (UczenTemp[i].Pesel.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 8:
                                if (UczenTemp[i].Plec.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 9://klasa
                                if (UczenTemp[i].Klasa.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                            case 10://grupy
                                if (UczenTemp[i].Grupy.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + UczenTemp[i].ReturnForPrint();
                                }
                                break;
                        }
                    }
                    if (String.EndsWith("N"))
                    {
                        int i = Int32.Parse(String.Substring(String.Length - 2, 1));
                        //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                        switch (WybranePole)
                        {
                            case 0:
                                if (NauczycielTemp[i].Imie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 1:
                                if (NauczycielTemp[i].DrugieImie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 2:
                                if (NauczycielTemp[i].Nazwisko.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 3:
                                if (NauczycielTemp[i].NazwiskoPaniejskie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 4:
                                if (NauczycielTemp[i].ImieMatki.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 5:
                                if (NauczycielTemp[i].ImieOjca.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 6:
                                if (NauczycielTemp[i].DataUrodzenia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 7:
                                if (NauczycielTemp[i].Pesel.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 8:
                                if (NauczycielTemp[i].Plec.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 11://Wychowawstwo
                                if (NauczycielTemp[i].WychowawcaKlasa.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 12://Przedmioty
                                if (NauczycielTemp[i].PrzedmiotyNauczane.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 13://Zajecia
                                if (NauczycielTemp[i].Zajecia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                            case 14://Data Zatrudnienia
                                if (NauczycielTemp[i].DataZatrudnienia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + NauczycielTemp[i].ReturnForPrint();
                                }
                                break;
                        }
                    }
                    if (String.EndsWith("P"))
                    {
                        int i = Int32.Parse(String.Substring(String.Length - 2, 1));
                        //MEGA switch sprawdzający wszystkie mozliwe pola jakie uzytkownik mogl wybrac w sortowaniu
                        switch (WybranePole)
                        {
                            case 0:
                                if (PracownikTemp[i].Imie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 1:
                                if (PracownikTemp[i].DrugieImie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 2:
                                if (PracownikTemp[i].Nazwisko.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 3:
                                if (PracownikTemp[i].NazwiskoPaniejskie.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 4:
                                if (PracownikTemp[i].ImieMatki.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 5:
                                if (PracownikTemp[i].ImieOjca.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 6:
                                if (PracownikTemp[i].DataUrodzenia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 7:
                                if (PracownikTemp[i].Pesel.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 8:
                                if (PracownikTemp[i].Plec.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 14://Data Zatrudnienia
                                if (PracownikTemp[i].DataZatrudnienia.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 15://Etat
                                if (PracownikTemp[i].Etat.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                            case 16://Opis
                                if (PracownikTemp[i].Opis.Equals(String.Remove(String.Length - 2).ToString()))
                                {
                                    Tab_Item_Widok_TextBox.Text = Tab_Item_Widok_TextBox.Text + PracownikTemp[i].ReturnForPrint();
                                }
                                break;
                        }
                    }
                }
            }
        }
        private void Sortuj_Gotowe_Click(object sender, RoutedEventArgs e)
        {
            //Wybrany index wskazujący po którym polu tabeli sortowac
            // i "Sort Type" który wskazuje ile tabel w sortowaniu bieze udzial
            int SelectedItemIndex=Sortuj_SelectBox.SelectedIndex;
            int SortType = 0;
            if (SelectedItemIndex <= 14) { SortType = 3; }
            if (SelectedItemIndex == 15) { SortType = 2; }
            if (SelectedItemIndex > 15) { SortType = 1; }
            Sortuj(SortType,TableUczen,TableNauczyciel,TablePracownik,SelectedItemIndex);
            
            Tab_Item_Sortuj.Visibility = Visibility.Hidden;
            Tab_Item_Widok.IsSelected = true;

            Tab_Item_Widok.Visibility = Visibility.Visible;
            Tab_Item_Rekord.Visibility = Visibility.Visible;
        }

        private void Plik_Szukaj_Click(object sender, RoutedEventArgs e) //przelaczanie na tab szukania, chowając inne
        {
            Tab_Item_Szukaj.Visibility = Visibility.Visible;
            Tab_Item_Szukaj.IsSelected = true;

            Tab_Item_Widok.Visibility = Visibility.Hidden;
            Tab_Item_Rekord.Visibility = Visibility.Hidden;
        }
        private void Szukaj_Wroc_Click(object sender, RoutedEventArgs e)
        {
            Tab_Item_Szukaj.Visibility = Visibility.Hidden;
            Tab_Item_Widok.IsSelected = true;

            Tab_Item_Widok.Visibility = Visibility.Visible;
            Tab_Item_Rekord.Visibility = Visibility.Visible;
        }

        private void Szukaj_Gotowe_Click(object sender, RoutedEventArgs e)
        {         
            int SelectedSortIndex = SzukajSortuj_SelectBox.SelectedIndex;

            int SelectedSearchIndex = SzukajPo_SelectBox.SelectedIndex;
            int SelectedSearchTypeIndex = SzukajSposob_SelectBox.SelectedIndex;
            string Filtr = Szukaj_Filtr.Text;
            bool okej = true;

            Uczen[] TempUczen = new Uczen[0];
            Nauczyciel[] TempNauczyciel = new Nauczyciel[0];
            Pracownik[] TempPracownik = new Pracownik[0];
            if ((SelectedSearchIndex != 6 || SelectedSearchIndex != 14 )&& (SelectedSearchTypeIndex == 4 || SelectedSearchTypeIndex==5))
            {
                okej = false;
                SzukajPo_SelectBox.Foreground = Brushes.Red;
                SzukajSposob_SelectBox.Foreground = Brushes.Red;
                Szukaj_ErrorLabel.Content = "Nie Zgodne Kryteria";
            }
            else
            {
                SzukajPo_SelectBox.Foreground = Brushes.Black;
                SzukajSposob_SelectBox.Foreground = Brushes.Black;
                Szukaj_ErrorLabel.Content = "";
            }          

            if (okej) { 
            for(int i = 0; i < TableUczen.Length; i++)
                {
                    string wartosc="";
                    switch (SelectedSearchIndex)
                    {
                        case 0:
                            wartosc = TableUczen[i].Imie;
                            break;
                        case 1:
                            wartosc = TableUczen[i].DrugieImie;
                            break;
                        case 2:
                            wartosc = TableUczen[i].Nazwisko;
                            break;
                        case 3:
                            wartosc = TableUczen[i].NazwiskoPaniejskie;
                            break;
                        case 4:
                            wartosc = TableUczen[i].ImieMatki;
                            break;
                        case 5:
                            wartosc = TableUczen[i].ImieOjca;
                            break;
                        case 6:
                            wartosc = TableUczen[i].DataUrodzenia;
                            break;
                        case 7:
                            wartosc = TableUczen[i].Pesel;
                            break;
                        case 8:
                            wartosc = TableUczen[i].Plec;
                            break;
                        default:
                            break;

                        case 9:
                            wartosc = TableUczen[i].Klasa;
                            break;
                        case 10:
                            wartosc = TableUczen[i].Grupy;
                            break;
                    }
                    Uczen[] TempTempUczen = new Uczen[1];
                    bool Good = false;
                    switch (SelectedSearchTypeIndex)
                    {
                        case 0:
                            if (wartosc.Contains(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 1:
                            if (wartosc==Filtr)
                            {
                                Good = true;
                            }
                            break;
                        case 2:
                            if (wartosc.EndsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 3:
                            if (wartosc.StartsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 4:
                            if (string.Compare(Filtr, wartosc) ==1)
                            {
                                Good = true;
                            }
                            break;
                        case 5:
                            if (string.Compare(wartosc, Filtr) == 1)
                            {
                                Good = true;
                            }
                            break;
                    }
                    if (Good)
                    {
                        TempTempUczen[0] = TableUczen[i];
                        TempUczen = TempUczen.Concat(TempTempUczen).ToArray();
                    }
                }
            for (int i = 0; i < TableNauczyciel.Length; i++)
                {
                    string wartosc = "";
                    switch (SelectedSearchIndex)
                    {
                        case 0:
                            wartosc = TableNauczyciel[i].Imie;
                            break;
                        case 1:
                            wartosc = TableNauczyciel[i].DrugieImie;
                            break;
                        case 2:
                            wartosc = TableNauczyciel[i].Nazwisko;
                            break;
                        case 3:
                            wartosc = TableNauczyciel[i].NazwiskoPaniejskie;
                            break;
                        case 4:
                            wartosc = TableNauczyciel[i].ImieMatki;
                            break;
                        case 5:
                            wartosc = TableNauczyciel[i].ImieOjca;
                            break;
                        case 6:
                            wartosc = TableNauczyciel[i].DataUrodzenia;
                            break;
                        case 7:
                            wartosc = TableNauczyciel[i].Pesel;
                            break;
                        case 8:
                            wartosc = TableNauczyciel[i].Plec;
                            break;
                        default:
                            break;

                        case 11:
                            wartosc = TableNauczyciel[i].WychowawcaKlasa;
                            break;
                        case 12:
                            wartosc = TableNauczyciel[i].PrzedmiotyNauczane;
                            break;
                        case 13:
                            wartosc = TableNauczyciel[i].Zajecia;
                            break;
                        case 14:
                            wartosc = TableNauczyciel[i].DataZatrudnienia;
                            break;
                    }
                    Nauczyciel[] TempTempNauczyciel = new Nauczyciel[1];
                    bool Good = false;
                    switch (SelectedSearchTypeIndex)
                    {
                        case 0:
                            if (wartosc.Contains(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 1:
                            if (wartosc == Filtr)
                            {
                                Good = true;
                            }
                            break;
                        case 2:
                            if (wartosc.EndsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 3:
                            if (wartosc.StartsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 4:
                            if (string.Compare(Filtr, wartosc) == 1)
                            {
                                Good = true;
                            }
                            break;
                        case 5:
                            if (string.Compare(wartosc, Filtr) == 1)
                            {
                                Good = true;
                            }
                            break;
                    }
                    if (Good)
                    {
                        TempTempNauczyciel[0] = TableNauczyciel[i];
                        TempNauczyciel = TempNauczyciel.Concat(TempTempNauczyciel).ToArray();
                    }
                }
            for (int i = 0; i < TablePracownik.Length; i++)
                {
                    string wartosc = "";
                    switch (SelectedSearchIndex)
                    {
                        case 0:
                            wartosc = TablePracownik[i].Imie;
                            break;
                        case 1:
                            wartosc = TablePracownik[i].DrugieImie;
                            break;
                        case 2:
                            wartosc = TablePracownik[i].Nazwisko;
                            break;
                        case 3:
                            wartosc = TablePracownik[i].NazwiskoPaniejskie;
                            break;
                        case 4:
                            wartosc = TablePracownik[i].ImieMatki;
                            break;
                        case 5:
                            wartosc = TablePracownik[i].ImieOjca;
                            break;
                        case 6:
                            wartosc = TablePracownik[i].DataUrodzenia;
                            break;
                        case 7:
                            wartosc = TablePracownik[i].Pesel;
                            break;
                        case 8:
                            wartosc = TablePracownik[i].Plec;
                            break;
                        default:
                            break;

                        case 14:
                            wartosc = TablePracownik[i].DataZatrudnienia;
                            break;
                        case 15:
                            wartosc = TablePracownik[i].Etat;
                            break;
                        case 16:
                            wartosc = TablePracownik[i].Opis;
                            break;
                    }
                    Pracownik[] TempTempPracownik = new Pracownik[1];
                    bool Good = false;
                    switch (SelectedSearchTypeIndex)
                    {
                        case 0:
                            if (wartosc.Contains(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 1:
                            if (wartosc == Filtr)
                            {
                                Good = true;
                            }
                            break;
                        case 2:
                            if (wartosc.EndsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 3:
                            if (wartosc.StartsWith(Filtr))
                            {
                                Good = true;
                            }
                            break;
                        case 4:
                            if (string.Compare(Filtr, wartosc) == 1)
                            {
                                Good = true;
                            }
                            break;
                        case 5:
                            if (string.Compare(wartosc, Filtr) == 1)
                            {
                                Good = true;
                            }
                            break;
                    }
                    if (Good)
                    {
                        TempTempPracownik[0] = TablePracownik[i];
                        TempPracownik = TempPracownik.Concat(TempTempPracownik).ToArray();
                    }
                }

                int SortType = 0; //cześciowo przekopiowany kod z sortowania

            if (SelectedSortIndex != 17) { 
                if (SelectedSortIndex <= 14) { SortType = 3; }
                if (SelectedSortIndex == 15) { SortType = 2; }
                if (SelectedSortIndex > 15) { SortType = 1; }
                Sortuj(SortType, TempUczen, TempNauczyciel, TempPracownik, SelectedSortIndex);
                }
                else
                {

                }
                Tab_Item_Szukaj.Visibility = Visibility.Hidden;
                Tab_Item_Widok.IsSelected = true;

                Tab_Item_Widok.Visibility = Visibility.Visible;
                Tab_Item_Rekord.Visibility = Visibility.Visible;
            }
        }
        private void Szukaj_Raport_Click(object sender, RoutedEventArgs e)
        {
        }
    }
    }
