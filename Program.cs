using System;

namespace KursT2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void Q1()
        {
            //Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane które chcesz przetrzymywać to:
            //a.Imię,
            //b.Nazwisko
            //c.Wiek
            //d.Płeć(‘m’ albo ‘k’)
            //e.PESEL
            //f.Numer pracownika(np. 2509324094)
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

            Console.WriteLine("Zad. 1");

            string firstname;
            string lastname;
            byte age;
            Gender gender;
            int[] pesel = new int[11];
            uint employeeID;
        }
        public void Q2()
        {
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.

            Console.WriteLine("Zad. 2");

            char ch1 = 'R';
            char ch2 = 'P';
            char ch3 = 'W';

            Console.WriteLine(ch3);
            Console.WriteLine(ch2);
            Console.WriteLine(ch1);
        }
        public void Q3()
        {
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. 
            //(Aby, obliczyć pierwiastek liczby użyj metody Math.Sqrt())
            Console.WriteLine("Zad. 3");

            double a;
            double b;

            Console.WriteLine("Podaj długość boku a: ");
            Double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj długość boku b: ");
            Double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine($"Długość przekątnej wynosi {Math.Sqrt(a*a + b*b)}");
        }
        public void Q4()
        {
            //Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
            //a. 10
            //b.Szkoła Dotneta
            //c. 12,5
            //Pamiętaj o użyciu poprawnych typów danych.

            Console.WriteLine("Zad. 4");

            int a = 10;
            string b = "Szkoła Dotneta";
            double c = 12.5;
        }
        public void Q5()
        {
            //Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko, numer telefonu, adres email,
            //wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego
            //typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).

            Console.WriteLine("Zad. 5");

            string firstname;
            string lastname;
            int phoneNumber;
            string email;
            byte height;
            double weight;

            Console.WriteLine("Podaj swoje imię: ");
            firstname = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko: ");
            lastname = Console.ReadLine();
            Console.WriteLine("Podaj swój numer telefonu: ");
            Int32.TryParse(Console.ReadLine(), out phoneNumber);
            Console.WriteLine("Podaj swój adres e-mail: ");
            email = Console.ReadLine();
            Console.WriteLine("Podaj swój wzrost w cm: ");
            Byte.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("Podaj swoją wagę: ");
            Double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine("Twoje dane:");
            Console.WriteLine($"Personalia: {firstname} {lastname}");
            Console.WriteLine($"Numer telefonu: {phoneNumber}");
            Console.WriteLine($"Adres e-mail: {email}");
            Console.WriteLine($"Wzrost: {height} \t\t Waga: {weight}");
        }

        public enum Gender
        {
            M,
            K
        }
    }
}
