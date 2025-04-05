using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {

            Vehicle car = new Car();
            Vehicle plane = new Plene();
            Vehicle ship = new ship();


            car.ShowInfo();
            plane.ShowInfo();
            ship.ShowInfo();

        }
    }

    class Vehicle
    {
        private double x = 49.5;
        private double y = 38.12;
        private double prise = 12312.35;
        private double speed = 92;
        private DateTime yearOld = DateTime.Now;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Транспорт: X={x}, Y={y}, Ціна={prise}, Швидкість={speed}, Рік={yearOld.Year}");
        }
    }

    class Plene : Vehicle
    {
        private int width = 56;
        private int cauntPasenger = 15;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Літак: Висота={width}, Пасажири={cauntPasenger}");
        }
    }

    class Car : Vehicle
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Автомобіль: Звичайний транспорт");
        }
    }

    class ship : Vehicle
    {
        private int countPassengerToShip = 152;
        private string selectPort = "asdg";

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Корабель: Пасажири={countPassengerToShip}, Порт={selectPort}");
        }
    }


}