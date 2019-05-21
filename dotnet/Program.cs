﻿using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagePath = "fries.jpg";
            System.Console.WriteLine(imagePath);

            int firstIndex = 0;
            int lastIndex = Int32.Parse(args[0]);

            string path;

            Image<Rgba32> image;

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                path = $"../images/{i}.jpg";
                System.Console.WriteLine(path);
                using (image = Image.Load(imagePath))
                {
                    image.ConvertToGray();
                    image.Resize();
                    image.SaveAsPgm("here.pgm");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}