using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023
{
    abstract class Device
    {
        public abstract void Show();
        public abstract void Desc();
        public abstract void Sound();
    }
    class Kettle : Device
    {
        public override void Show() => Console.WriteLine("Чайник");
        public override void Desc() => Console.WriteLine("Греет воду");
        public override void Sound() => Console.WriteLine("*свист*");

    }
    class Microwave : Device
    {
        public override void Show() => Console.WriteLine("Микроволновка");
        public override void Desc() => Console.WriteLine("Греет еду");
        public override void Sound() => Console.WriteLine("*пип-пип*");
    }
    class Car : Device
    {
        public override void Show() => Console.WriteLine("Автомобиль");
        public override void Desc() => Console.WriteLine("Транспорт");
        public override void Sound() => Console.WriteLine("*вррр-вррр*");
    }
    class Steamer : Device
    {
        public override void Show() => Console.WriteLine("Пароход");
        public override void Desc() => Console.WriteLine("Ходит по воде");
        public override void Sound() => Console.WriteLine("*ту-ту*");
    }
}
