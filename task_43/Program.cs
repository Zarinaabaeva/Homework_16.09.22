
double Prompt(string message)
{
    System.Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

Point IntersectionPoint(double b1, double k1, double b2,double k2)
{
Point point = new Point();

            if (k1 == k2 && b1 == b2)
                Console.Write("Прямые совпадают ");
            else if (k1 == k2)
                Console.Write("Прямые параллельныe ");
            else 
            {
             point.x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
             point.y = Math.Round((k1*(b2 - b1) / (k1 - k2) + b1), 1);
             Console.Write($"Прямые пересекаются в точке с координатами -> x = {point.x}, y = {point.y}");
            }
            
            return point;
    }    

     double b1 = Prompt("Введите b1 ");
     double k1 = Prompt("Введите k1 ");
     double b2 = Prompt("Введите b2 ");
     double k2 = Prompt("Введите k2 ");
     IntersectionPoint(b1, k1, b2, k2);
