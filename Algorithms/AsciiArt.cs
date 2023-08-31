namespace Algorithms;

using System;
using System.Text;
public class AsciiArt
{
    static string CreateStaircase(int height, int width)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                for (int k = 0; k < width + (i * (width - 1)); k++)
                {
                    sb.Append("#");
                }
                sb.AppendLine();
            }
        }

        return sb.ToString();
    }

    static void Main(string[] args)
    {
        int height = 2;
        int width = 3;
        string staircase = CreateStaircase(height, width);
        Console.WriteLine(staircase);
    }
}