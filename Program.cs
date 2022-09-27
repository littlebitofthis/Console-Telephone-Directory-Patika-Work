using System;
using System.Runtime.InteropServices;

namespace PhoneBookConsole
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine($"Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine($"****************************************");
            Console.WriteLine($"(1) Yeni Numara Kaydetmek");
            Console.WriteLine($"(2) Kişiyi numara göre göster");
            Console.WriteLine($"(3) Rehberi Listelemek");
            Console.WriteLine($"(4) Rehberde Arama Yapmak");
            Console.WriteLine($"Programdan çıkmak için x'e basın");

            var userInput = Console.ReadLine();

            var phonebook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Kişi adı girin");
                        var name = Console.ReadLine();
                        Console.WriteLine("Kişi numarası girin");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phonebook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Aramak İçin Numara giriniz");
                        var searchNumber = Console.ReadLine();
                        phonebook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phonebook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Arama yapmak için isim giriniz");
                        var searchPhrase = Console.ReadLine();
                        phonebook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Numara silmek için isim giriniz");
                        Console.WriteLine();
                  


                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Geçerli seçenek seçin");
                        break;
                }

                Console.WriteLine("İşlem seçin");
                userInput = Console.ReadLine();
            }
        }
    }
}