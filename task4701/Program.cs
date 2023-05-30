// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double y;
y=1.23;

Console.WriteLine(y);


int amount = 4562122;
//Convert.ToInt32(Console.ReadLine());
            double[] massiv = new double[amount];
 
            
            double x = 0d;
            Random random = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.NextDouble();
                x = massiv[i];
                if (x<0.0001) Console.WriteLine(x*1000000);
            }
 
            //Console.Write(Array.Sort(x));
