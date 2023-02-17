using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023
{
    abstract class Worker
    {
        public abstract void Print();
    }
    class President : Worker
    {
        public override void Print() => Console.WriteLine("Я призидент, я призиденчу");
    } 
    class Security : Worker
    {
        public override void Print() => Console.WriteLine("Я охраник, я охраняю");

    }
    class Manager : Worker
    {
        public override void Print() => Console.WriteLine("Я менеджер, я менеджерю");

    }
    class Engineer : Worker
    {
        public override void Print() => Console.WriteLine("Я инженер, я инженерю");

    }
}
