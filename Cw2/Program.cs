using System;
using System.Collections.Generic;
using System.IO;

namespace Cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\User\Desktop\dane.csv";

            // Wszystkie linie z pliku dodajemy do kolekcji (IEnumerable<string>)
            var lines = File.ReadLines(path);

            // Iterujemy po kolekcji zawierającej linie
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            // Parsujemy stringa zawierającego datę na typ DateTime
            var parsedDate = DateTime.Parse("09.03.2020");
            Console.WriteLine(parsedDate);
            // Żeby unikać hardcodowania wartości daty, używamy atrybutu
            // Today zwraca dzisiejszą datę z czasem 00:00:00
            // Alternatywą DateTime.Now -> zwraca datę z aktualnym czasem
            var today = DateTime.Today;

            // Jeżeli nie chcemy mieć informacji dot. czasu używamy metody 
            // ToShortDateString()
            Console.WriteLine(today.ToShortDateString());

            // Ładniejszy odpowiednik ""
            var str = string.Empty;

            // Sprawdzanie czy zmienna podana jako argument metody ma wartość
            //null lub jest pusta
            if (string.IsNullOrEmpty(str))
            {}

            // Sprawdzanie czy zmienna podana jako argument metody ma wartość
            // null lub biały znak, np. spacje
            if (string.IsNullOrWhiteSpace(str))
            {}

            // Tworzymy nową kolekcję HashSet przechowującą obiekty klasy Student
            // Dodatkowo używamy napisanego przez nas komparatora, żeby działał wg.
            // logiki wymaganej w zadaniu, a nie domyślnej
            var hash = new HashSet<Student>(new OwnComparer());

            var stud1 = new Student
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                Index = "1234"
            };

            var stud2 = new Student
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                Index = "1234"
            };

            var stud3 = new Student
            {
                FirstName = "Janina",
                LastName = "Nowak",
                Index = "1234"
            };

            //dodajemy utworzone wyżej obiekty do HashSet
            hash.Add(stud1);
            hash.Add(stud2);
            hash.Add(stud3);

            // Wyświetlamy rozmiar HashSet. 
            // Bez naszego komparatora wszystkie obiekty zostaną dodane - wynik: 3
            // Z naszym komparatorem - brak powtórzeń - wynik:2
            Console.WriteLine(hash.Count);
            
            var newStud = new Student();

            // Metoda "Add" HashSet zwraca wartość true lub false
            // False oznacza, że nie udało się dodać danego obiektu
            // (w naszym przypadku oznacza to duplikat i powinniśmy potraktować
            // to jako błąd, czyli dodać do pliku log.txt)
            if (!hash.Add(newStud))
            {
                // Znaleźliśmy duplikat, więc dodajemy to do pliku log.txt
                // Dzięki utworzeniu wcześniej obiektu nie musimy się powtarzać
                // tylko od razu jesteśmy w stanie użyć tego samego obiektu do logowania błędów
            }
                                 
            
        }
    }
}
