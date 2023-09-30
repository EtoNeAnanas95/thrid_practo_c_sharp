using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static ConsoleKey global_key = ConsoleKey.F1;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Для выхода нажмите клавишу F4");
            Console.ResetColor();
            do
            {
                if (global_key == ConsoleKey.F1)
                {
                    octava_1();
                }
                else if (global_key == ConsoleKey.F2)
                {
                    octava_2();
                }
            }
            while (global_key != ConsoleKey.F4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы вышли из пианино");
            Console.ResetColor();
        }

        static void octava_1()
        {
            int[] firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вы были переключены на первую актаву");
            Console.ResetColor();
            while (global_key == ConsoleKey.F1)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.F2)
                {
                    global_key = keyInfo.Key;
                    return;
                }
                if (keyInfo.Key == ConsoleKey.F4)
                {
                    global_key = keyInfo.Key;
                    return;
                }
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(firstOctave[0], 200);
                        break;

                    case ConsoleKey.W:
                        Console.Beep(firstOctave[1], 200);
                        break;

                    case ConsoleKey.E:
                        Console.Beep(firstOctave[2], 200);
                        break;

                    case ConsoleKey.R:
                        Console.Beep(firstOctave[3], 200);
                        break;

                    case ConsoleKey.T:
                        Console.Beep(firstOctave[4], 200);
                        break;

                    case ConsoleKey.Y:
                        Console.Beep(firstOctave[5], 200);
                        break;

                    case ConsoleKey.U:
                        Console.Beep(firstOctave[6], 200);
                        break;

                    case ConsoleKey.I:
                        Console.Beep(firstOctave[7], 200);
                        break;

                    case ConsoleKey.O:
                        Console.Beep(firstOctave[8], 200);
                        break;

                    case ConsoleKey.P:
                        Console.Beep(firstOctave[9], 200);
                        break;

                    case ConsoleKey.Oem4:
                        Console.Beep(firstOctave[10], 200);
                        break;

                    case ConsoleKey.Oem6:
                        Console.Beep(firstOctave[11], 200);
                        break;

                }
            }
        }

        static void octava_2()
        {
            int[] secondOctave = new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вы были переключены на первую актаву");
            Console.ResetColor();
            while (global_key == ConsoleKey.F2)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.F1)
                {
                    global_key = keyInfo.Key;
                    return;
                }
                if (keyInfo.Key == ConsoleKey.F4)
                {
                    global_key = keyInfo.Key;
                    return;
                }
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(secondOctave[0], 200);
                        break;

                    case ConsoleKey.W:
                        Console.Beep(secondOctave[1], 200);
                        break;

                    case ConsoleKey.E:
                        Console.Beep(secondOctave[2], 200);
                        break;

                    case ConsoleKey.R:
                        Console.Beep(secondOctave[3], 200);
                        break;

                    case ConsoleKey.T:
                        Console.Beep(secondOctave[4], 200);
                        break;

                    case ConsoleKey.Y:
                        Console.Beep(secondOctave[5], 200);
                        break;

                    case ConsoleKey.U:
                        Console.Beep(secondOctave[6], 200);
                        break;

                    case ConsoleKey.I:
                        Console.Beep(secondOctave[7], 200);
                        break;

                    case ConsoleKey.O:
                        Console.Beep(secondOctave[8], 200);
                        break;

                    case ConsoleKey.P:
                        Console.Beep(secondOctave[9], 200);
                        break;

                    case ConsoleKey.Oem4:
                        Console.Beep(secondOctave[10], 200);
                        break;

                    case ConsoleKey.Oem6:
                        Console.Beep(secondOctave[11], 200);
                        break;

                }
            }
        }
    }
}