using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcosistemaUrbano
{
   public class marcos
    {
        private static int Width;
        private static int Hieght;
        private static int LocationX;
        private static int LocationY;

        private static ConsoleColor BorderColor;

        public static void Draw()
        {
            string s = "╔";
            string space = "";
            string temp = "";
            Parallel.For(0, Width, i => {
                space += " ";
                s += "═";
            });
            Parallel.For(0, LocationX, j => {
                temp += " ";
            });
            s += "╗" + "\n";
            
            Parallel.For(0, Hieght, i => {
                    s += temp + "║" + space + "║" + "\n";
            });
            s += temp + "╚";

            
                Parallel.For(0, Width, i => {
                    s += "═";
                });
            s += "╝" + "\n";
            
                Console.ForegroundColor = BorderColor;
            Console.CursorTop = LocationY;
            Console.CursorLeft = LocationX;
            Console.Write(s);
            Console.ResetColor();

        }

        public static void ConsoleRectangle(int width, int hieght, int locationX, int locationY, ConsoleColor borderColor)
        {
            Width = width;
            Hieght = hieght;
            LocationX = locationX;
            LocationY = locationY;
            BorderColor = borderColor;
        }
        //static void Main(string[] args)
        //{
        //    ConsoleRectangle(20, 10, 7, 8, ConsoleColor.DarkRed);
        //    Draw();

        //    Console.ReadLine();
        //}
    }
}
