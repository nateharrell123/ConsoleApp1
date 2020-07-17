using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Parakeet : Bird
    {
        public override string Name => "Dinky";

        private Color color;
        public override Color Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == Color.Red)
                {
                    Console.WriteLine("Red is lame pick something else!!");
                }
                else color = value;
            }
        }

        public override string Call()
        {
            return $"My names is {Name} and i'm a {GetType()}. My color is {Color}.";
        }

        public Color ChangeColor()
        {
            Console.WriteLine("Type a color:");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "Red":
                    return Color.Red;
                case "Blue":
                    return Color.Blue;
                case "Green":
                    return Color.Green;
                case "White":
                    return Color.White;
                default:
                    throw new Exception("Color doesn't exist");
            }
        }
    }
}
