using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacks_house
{
    public class Part1
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part1 = "Вот дом,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part1);
        }
    }

    public class Part2
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part2 = "А это пшеница,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part2);
        }
    }

    public class Part3
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part3 = "А это веселая птица-синица,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part3);
        }
    }


    public class Part4
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part4 = "Вот кот,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part4);
        }
    }

    public class Part5
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part5 = "Вот пес без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part5);
        }
    }

    public class Part6
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part6 = "А это корова безрогая,\r\n" +
                "Лягнувшая старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part6);
        }
    }

    public class Part7
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part7 = "А это старушка, седая и строгая,\r\n" +
                "Которая доит корову безрогую,\r\n" +
                "Лягнувшую старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part7);
        }
    }

    public class Part8
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part8 = "А это ленивый и толстый пастух,\r\n" +
                "Который бранится с коровницей строгою,\r\n" +
                "Которая доит корову безрогую,\r\n" +
                "Лягнувшую старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part8);
        }
    }

    public class Part9
    {
        public ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list)
        {
            string part9 = "Вот два петуха,\r\n" +
                "Которые будят того пастуха,\r\n" +
                "Который бранится с коровницей строгою,\r\n" +
                "Которая доит корову безрогую,\r\n" +
                "Лягнувшую старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\n" +
                "В доме,\r\n" +
                "Который построил Джек.";
            Poem = list.Add(part9);
        }
    }
}
