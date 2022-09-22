Console.Write("Введите b1: ");
double numberB1 = double.Parse(Console.ReadLine());

Console.Write("Введите k1: ");
double numberK1 = double.Parse(Console.ReadLine());

Console.Write("Введите b2: ");
double numberB2 = double.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double numberK2 = double.Parse(Console.ReadLine());

double Xisk = (numberB1 - numberB2)/(numberK2 - numberK1);
double Yisk = numberK1*Xisk + numberB1;

Console.WriteLine("Точка пересечения М(" + Xisk + "; " + Yisk + ")");



