using Polimorphism;

Console.WriteLine("1. Square\n2. Rectngular\n0. Quit");
int choise = int.Parse(Console.ReadLine());
if ( choise == 1)
{
    Square square = new(int.Parse(Console.ReadLine()));
    Console.WriteLine(square.CalcArea());
}
else if ( choise == 2)
{
    Rectangular rectangular = new(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    Console.WriteLine(rectangular.CalcArea());
}
else
{
    
}
