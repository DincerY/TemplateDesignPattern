using System;

namespace Template_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mause mause = new Mause();
            mause.TemplateMethod();
            Console.WriteLine();
            Televizyon televizyon = new Televizyon();
            televizyon.TemplateMethod();
            Console.ReadLine();
        }
    }
}
