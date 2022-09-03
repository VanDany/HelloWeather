using System;
using System.Threading;

namespace HelloWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string endMessage = "C:\\Users\\42\\source\\repos\\HelloWorld\\bin\\Debug\\net5.0\\HelloWeather.exe (process 18812) exited with code 0.\nTo automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops. \nPress any key to close this window. . .";
            Console.Write(endMessage);
            Console.ReadKey();
            int sleepVelocity = 30;
            string helloWorld = "Hello World!";
            string eather = "EATHER!";
            string eatherTemp;
            int totalMessage = endMessage.Length;

            //SUN
            double radius = 5;
            double thickness = 0.4;
            char symbol = '*';

            while (true)
            {
                Console.Clear();
                ConsoleColor BorderColor = ConsoleColor.White;
                Console.ForegroundColor = BorderColor;
                for (int i = 0; i < totalMessage; i++)
                {
                    Thread.Sleep(sleepVelocity);
                    Console.Clear();
                    Console.WriteLine(helloWorld);
                    if (endMessage.Length > 5)
                        endMessage = endMessage.Substring(0, endMessage.Length - 5);
                    else
                    {
                        endMessage = "";
                        totalMessage = 0;
                    }
                    Console.Write(endMessage);
                }
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(700);
                    helloWorld = helloWorld.Substring(0, helloWorld.Length - 1);
                    Console.SetCursorPosition(0, 0);
                    Console.Write(helloWorld);
                }

                for (int i = 0; i < 7; i++)
                {
                    Thread.Sleep(700);
                    eatherTemp = eather.Substring(i, 1);
                    Console.Write(eatherTemp);
                }
                Console.ReadKey();
                helloWorld = "Hello World!";
                eather = "EATHER!";
                eatherTemp = "";
                totalMessage = endMessage.Length;

                Console.WriteLine();

                //SUN
                BorderColor = ConsoleColor.Yellow;
                Console.ForegroundColor = BorderColor;
                if (radius == 5)
                    radius = radius + 1;
                else radius = radius - 1;
                double rIn = radius - thickness, rOut = radius + thickness;
                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
