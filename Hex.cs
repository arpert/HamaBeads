using System;

public class Test
{
    public static void Main(string []args)
    {
        int n = 7;
        if (args.Length > 0)
           n = int.Parse(args[0]);

        System.Console.WriteLine("Writing hexagon: {0}\n", n);
        n = 2 * n - 1;
        int x0, y, y0;
        x0 = n / 2;
        y0 = n / 2;
        for(int i = 0; i < n; i++)
        {
          y = i - y0;
//          if ((i % 2) != 0)
//          System.Console.Write(" ");
          if (y < 0) y = -y;

          for(int j = 0; j < y; j++)
             System.Console.Write(" ");

          for(int j = 0; j < n - y; j++)
          {
             System.Console.Write("* ");
          }
          System.Console.WriteLine("");
        }
        System.Console.WriteLine("");

    }
}