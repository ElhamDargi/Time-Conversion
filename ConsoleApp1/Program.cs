using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            string str = "23:23:14";
            string[] arrayString = str.Split(":");
            if (int.Parse(arrayString[0])>12)
            {
                result = (int.Parse(arrayString[0]) - 12).ToString() + ":" + arrayString[1] + ":" + arrayString[2]+"PM";
            }
            else if (arrayString[0]=="00" )
            {
                result = "12:" + arrayString[1] + ":" + arrayString[2]+"AM";
            }
            else if (arrayString[0] == "12")
            {
                result = "12:" + arrayString[1] + ":" + arrayString[2] + "PM";
            }
            else 
            {
                result = arrayString[0] + ":" + arrayString[1] + ":" + arrayString[2] + "AM";
            }
            Console.WriteLine(result);
        }
    }
}
