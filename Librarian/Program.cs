using System.Collections.Concurrent;
// Библиотека (ConcurrentDictionary)
namespace Librarian
{
    internal class Program
    {
        public static ConcurrentDictionary<string, int> library = new ConcurrentDictionary<string, int>();
        static void Main(string[] args)
        {
            Task.Run(CalculateRead);
            int choise = 0;
            do
            {
                PrintMenu();
                bool isCorrectChoise = int.TryParse(Console.ReadLine(), out choise);
                if (!isCorrectChoise)
                {
                    continue;
                }

                switch (choise)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        PrintAllBooks();
                        break;                        
                }
            } while (choise != 3);            
            Console.WriteLine("Вы вышли из программы");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1 - добавить книгу");
            Console.WriteLine("2 - вывести список непрочитанного");
            Console.WriteLine("3 - выйти");
        }

        public static void AddBook()
        {
            Console.WriteLine("Введите название книги");
            string book = Console.ReadLine();
            library.TryAdd(book, 0);
        }

        public static void PrintAllBooks()
        {
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Key} - {item.Value}%");
            }            
        }

        public static async Task CalculateRead()
        {
            while (true)
            {
                foreach (var item in library)
                {                    
                    library[item.Key]++;                  
                    if (library[item.Key] >= 100)
                    {
                        library.TryRemove(item.Key, out int value);
                    }
                }
                await Task.Delay(1000);
            }            
        }
    }
}