using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023
{
    abstract class MusicalInstrument
    {
        string name;
        string title;
        string history;
        public MusicalInstrument(string name, string title, string history) 
        {
            this.name = name;
            this.title = title;
            this.history = history;
        }
        public void Show() => Console.WriteLine(name);
        public void Desc() => Console.WriteLine(title);
        public void History() => Console.WriteLine(history);
        public abstract void Sound();
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string title, string history) : base(name, title, history) { }
        public override void Sound() => Console.WriteLine("*Звук скрипки*");
    }
    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string title, string history) : base(name, title, history) { }
        public override void Sound() => Console.WriteLine("*Звук тромбона*");
    }
    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string title, string history) : base(name, title, history) { }
        public override void Sound() => Console.WriteLine("*Звук укулеле*");
    }
    class Cello : MusicalInstrument
    {
        public Cello(string name, string title, string history) : base(name, title, history) { }
        public override void Sound() => Console.WriteLine("*Звук виолончели*");
    }
}
