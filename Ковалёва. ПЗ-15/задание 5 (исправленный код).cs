using System;

class Auto  // лёгкий автомобиль
{
    public int Seats { get; set; } // количество сидений

    public Auto(int seats)
    {
        Seats = seats;
    }
}

class Truck : Auto // грузовой автомобиль
{
    public decimal Capacity { get; set; } // грузоподъемность

    public Truck(int seats, decimal capacity) : base(seats) // вызываем конструктор базового класса
    {
        Capacity = capacity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Truck truck = new Truck(2, 1.1m);
        Console.WriteLine($"Грузовик с грузоподъемностью {truck.Capacity} тонн");
        Console.ReadKey();
    }
}

