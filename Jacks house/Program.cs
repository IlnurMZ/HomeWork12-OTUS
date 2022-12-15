using System.Collections.Immutable;
// Дом, который построил Джек (ImmutableList)
namespace Jacks_house
{
    internal class Program
    {
        private static readonly List<string> list = new();
        public static ImmutableList<string> List { 
            get 
            {
                return list.ToImmutableList();
            }
}

        static void Main(string[] args)
        {
            Part1 part1 = new Part1();
            Part2 part2 = new Part2();
            Part3 part3 = new Part3();
            Part4 part4 = new Part4();
            Part5 part5 = new Part5();
            Part6 part6 = new Part6();
            Part7 part7 = new Part7();
            Part8 part8 = new Part8();
            Part9 part9 = new Part9();            

            part1.AddPart(List);
            part2.AddPart(part1.Poem);
            part3.AddPart(part2.Poem);
            part4.AddPart(part3.Poem);
            part5.AddPart(part4.Poem);
            part6.AddPart(part5.Poem);
            part7.AddPart(part6.Poem);
            part8.AddPart(part7.Poem);
            part9.AddPart(part8.Poem);

            Console.WriteLine("Part1:\n" + String.Join("\n", part1.Poem));
            Console.WriteLine();

            Console.WriteLine("Part2:\n" + String.Join("\n", part2.Poem));
            Console.WriteLine();

            Console.WriteLine("Part3:\n" + String.Join("\n", part3.Poem));
            Console.WriteLine();

            Console.WriteLine("Part4:\n" + String.Join("\n", part4.Poem));
            Console.WriteLine();

            Console.WriteLine("Part5:\n" + String.Join("\n", part5.Poem));
            Console.WriteLine();

            Console.WriteLine("Part6:\n" + String.Join("\n", part6.Poem));
            Console.WriteLine();

            Console.WriteLine("Part7:\n" + String.Join("\n", part7.Poem));
            Console.WriteLine();

            Console.WriteLine("Part8:\n" + String.Join("\n", part8.Poem));
            Console.WriteLine();

            Console.WriteLine("Part9:\n" + String.Join("\n", part9.Poem));
            Console.WriteLine();           

            Console.ReadKey();
        }
    }
}