using System;

class Circle
{
    private int x;
    private int y;
    private int radius;

    public Circle() : this(0, 0, 0) { } 

    public Circle(int radius) : this(0, 0, radius) { } 

   
    public Circle(int x, int y) : this(x, y, 0) { } 

    public Circle(int x, int y, int radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void Display()
    {
        Console.WriteLine($"Центр окружности: ({x}, {y}), Радиус: {radius}");
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle(); 
        Circle circle2 = new Circle(5); 
        Circle circle3 = new Circle(2, 3);
        Circle circle4 = new Circle(1, 1, 4); 

        circle1.Display();
        circle2.Display();
        circle3.Display();
        circle4.Display();
    }
}
