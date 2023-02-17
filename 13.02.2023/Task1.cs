using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023
{
    internal class Money
    {
        public int Whole { get; set; }
        public int Float { get; set; }
        public Money(int w, int f) { Whole = w; Float = f; }
        public Money() : this(0, 0) { }
        public override string ToString() => $"${Whole}.{Float}";
    }
    internal class Product : Money
    {
        public Product() : base() { }
        public Product(int w, int f) : base(w, f) { }
        public Product(Money pr) { Whole = pr.Whole; Float = pr.Float; }
        public static Product operator +(Product prod, Money mon)
        {
            return new Product(prod.Whole + mon.Whole, prod.Float + mon.Float);
        }
        public static Product operator -(Product prod, Money mon)
        {
            return new Product(prod.Whole - mon.Whole, prod.Float - mon.Float);
        }
    }
}
