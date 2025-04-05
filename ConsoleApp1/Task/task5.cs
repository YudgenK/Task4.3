using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task5
    {

        public void Run()
        {

            Printer defaultPrinter = new Printer();
            Printer redPrinter = new RedPrinter();
            Printer greenPrinter = new GreenPrinter();
            Printer bluePrinter = new BluePrinter();


            defaultPrinter.Print("Це текст за замовчуванням (білий)");
            redPrinter.Print("Це червоний текст");
            greenPrinter.Print("Це зелений текст");
            bluePrinter.Print("Це синій текст");


        }
    }


    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine(value);
            Console.ResetColor(); 
        }
    }

 
    class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

 
    class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

   
    class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

}

