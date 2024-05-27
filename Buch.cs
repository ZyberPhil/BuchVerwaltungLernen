using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using BuchVerwaltungLernen;
public class Buch
{
	public string Titel { get; private set; }
	public string Autor { get; private set; }
	public string ISBN { get; private set; }
	public int Erscheinungsjahr { get; private set; }

    private static List<Buch> buchListe = new List<Buch>();
    public Buch(string titel, string autor, string isbn, int erscheinungsjahr)
    {
		Titel = titel;
		Autor = autor;
        ISBN = isbn;
        Erscheinungsjahr = erscheinungsjahr;
    }

    public static void Hinzufuegen(Buch neuesBuch)
    {
        try
        { 
            buchListe.Add(neuesBuch);
            MessageBox.Show("Buch wurde hinzugefügt");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    public static void Entfernen(string isbn)
    {
        try
        {
            buchListe.RemoveAll(buch => buch.ISBN == isbn);
            MessageBox.Show("Buch wurde entfernt");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public override string ToString()
    {
        return $"Titel: {Titel}, Autor: {Autor}, ISBN: {ISBN}, Erscheinungsjahr: {Erscheinungsjahr}";
    }
    public static string Anzeigen() 
    {
        try
        {
            string buchListeString = "";
            foreach (Buch buch in buchListe)
            {
                buchListeString += buch.ToString() + "\n";
            }
            return buchListeString;
        }
        catch (Exception ex)
        {
            return "";
            MessageBox.Show(ex.Message);
        }
    }
}
