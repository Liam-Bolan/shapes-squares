using System;

namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
             
            DrawRectangle((ConsoleColor)c+5, 51, 13, 25, 11);
            
            DrawRectangle((ConsoleColor)c+1, 35, 15, 16, 3);
           
            DrawRectangle((ConsoleColor)c+2, 76, 15, 16, 3);
            
            DrawRectangle((ConsoleColor)c+3, 58, 8, 11, 5);

            DrawRectangle((ConsoleColor)c+8, 54, 24, 5, 8);

            DrawRectangle((ConsoleColor)c+6, 68, 24, 5, 8);

            Console.ReadLine();
        }

        
        static void DrawRectangle(ConsoleColor C, int x, int y, int w, int h)
        {

            int xpos = x;
            int ypos = y;
            Console.BackgroundColor = C;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");

                }
              
            }
        }

        
    }
}


