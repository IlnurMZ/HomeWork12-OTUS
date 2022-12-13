using System.Collections.ObjectModel;
using System.Collections.Specialized;
// Постоянный покупатель (ObserbableCollection)
namespace HomeWork12_OTUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appleStore = new Shop("Apple");
            var human = new Customer("John");

            human.Subscribe(appleStore);

            PrintMenu();
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            int i = 0;

            while (key.Key != ConsoleKey.X)
            {
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Item item = new Item(++i, $"Товар от {DateTime.Now.ToString("g")}");
                        appleStore.Add(item);
                        break;
                    case ConsoleKey.D:
                        try
                        {
                            Console.WriteLine("Введите идентификатор товара, который хотите удалить");
                            int id_D = int.Parse(Console.ReadLine());
                            appleStore.Remove(id_D);
                        }
                        catch
                        {
                            Console.WriteLine("Не удалось выполнить удаление =(");
                        }                       
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует");
                        break;
                }
                PrintMenu();
                key = Console.ReadKey();
                Console.WriteLine();
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Нажмите клавишу 'A' чтобы добавить товар");
            Console.WriteLine("Нажмите клавишу 'D' чтобы удалить товар");
            Console.WriteLine("Нажмите клавишу 'X' чтобы выйти из программы");
        }
    }

    public class Shop 
    {
        public ObservableCollection<Item> list = new ObservableCollection<Item>();
        public string Title { get; set; }

        public Shop(string title)
        {
            Title = title;
        }

        public void Add(Item item)
        {
            list.Add(item);
        }

        public void Remove(int id)
        {
            Item item_D = list.First(x => x.Id == id);
            list.Remove(item_D);
        }
    }

    public class Customer
    {
        private Shop _shop;
        public string Name { get; set; }       

        public Customer(string name)
        {
            Name = name;
        }
        public void Subscribe(Shop shop)
        {
            _shop = shop;
            _shop.list.CollectionChanged += OnItemChanged;
            Console.WriteLine($"{Name}: подписался на изменения магазина {_shop.Title}");
        }

        private void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Item item_A = (Item)e.NewItems?[0];
                    Console.WriteLine($"{Name}: в магазин {_shop.Title} добавили товар название: {item_A.Name}, id: {item_A.Id}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Item item_D = (Item)e.OldItems?[0];
                    Console.WriteLine($"{Name}: в магазине {_shop.Title} удалили товар название: {item_D.Name}, id {item_D.Id}");
                    break;                
            }            
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}