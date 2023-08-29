// namespace Algorithms.Devoir1;

// using System;

// public class Ascii
// {
//     private int height;
//     private int width;
//     public Ascii(int height, int width)
//     {
//         //StringBuilder sb = new StringBuilder();
//         this.height = height;
//         this.width = width;

//         for (int i = 0; i < height; i++)
//         {
//             for (int j = 0; j < width; j++)
//             {
//                 for (int k = 0; k < i + 2; k++)
//                 {
//                     sb.Append("#");
//                 }
//                 sb.AppendLine();
//             }
//         }

//         return sb.ToString();
//     }

//     static void Main(string[] args)
//     {
//         int height = 2;
//         int width = 3;
//         string staircase = Ascii(height, width);
//         Console.WriteLine(staircase);
//     }
// }
