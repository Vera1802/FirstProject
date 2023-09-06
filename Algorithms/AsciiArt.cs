namespace Algorithms;

using System;
using System.Text;
public class AsciiArt
{
    public string CreateStaircase(int height, int width)
    {
        string staircase = "";

        for (int i = 1; i <= height; i+=2)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < width + i - 1; k++)
                {
                    for (int l = 0; l < width; l++)
                    {
                        staircase += "#";
                    }
                    staircase += " ";
                }
                staircase += Environment.NewLine;
            }
        }

        return staircase;
    }

    // static void Main(string[] args)
    // {
    //     int height = 5; 
    //     int width = 7;  
    //     string staircase = CreateStaircase(height, width);
    //     Console.WriteLine(staircase);
    // }
}