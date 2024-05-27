using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuchVerwaltungLernen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
                string titel = tbTitel.Text;
                string autor = tbAutor.Text;
                string isbn = tbIsbn.Text;
                int erscheinungsjahr = Convert.ToInt32(tbErscheinungsjahr.Text);
                Buch neuesBuch = new Buch(titel, autor, isbn, erscheinungsjahr);
                Buch.Hinzufuegen(neuesBuch);
                Reload();
                
        }

        private void bDel_Click(object sender, RoutedEventArgs e)
        {
            string isbn = tbIsbn.Text;
            Buch.Entfernen(isbn);
            Reload();
        }
        public void Reload()
        {
            lShow.Content = Buch.Anzeigen();
        }
        private void bShow_Click(object sender, RoutedEventArgs e)
        {
            lShow.Content = Buch.Anzeigen();
        }
    }
}