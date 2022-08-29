// See https://aka.ms/new-console-template for more information


int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void Main(double k1, double b1, double k2, double b2)
{
  if(b1 == b2 && k1 == k2)
  {
    System.Console.WriteLine("Прямые совпадают");
  }
  else if(k1 == k2)
  {
    System.Console.WriteLine("Прямые параллельны");
  }
  else
  {
    (var x, var y) = SystemSolution(k1, b1, k2, b2);
    System.Console.WriteLine($"Координаты точки пересечения ({x:f2}; {y:f2})");
  }
}
(double, double) SystemSolution(double k1, double b1, double k2, double b2)
{
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1; 
  return (x,y);
}
int k1 = Prompt("Введите значение k1 ->"); 
int b1 = Prompt("Введите значение b1 ->"); 
int k2 = Prompt("Введите значение k2 ->"); 
int b2 = Prompt("Введите значение b2 ->"); 
Main(k1, b1, k2, b2);