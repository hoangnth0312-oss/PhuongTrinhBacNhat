Console.WriteLine("Linear Equation Resolver");
Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");


Console.WriteLine("nhap a: ");
Double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("nhap b: ");
Double b = Convert.ToDouble(Console.ReadLine());

double x = (-b)/a;

if (a == 0)
{
    if (b == 0)
    {
        Console.WriteLine("Phuong trinh vo so nghiem!");
    }
    else
    {
        Console.WriteLine("Phuong trinh vo nghiem!");
    }
}
else
{
    Console.WriteLine("Phuong trinh co nghiem x: " + x);
}