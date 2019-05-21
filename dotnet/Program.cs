using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagePath = "fries.jpg";
            System.Console.WriteLine(imagePath);
            int width = 128;
            int height = 128;
            // Image newImage = Image.FromFile(imagePath);
            using(FileStream pngStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using(var image = new Bitmap(pngStream))
            {
                var resized = new Bitmap(width, height);
                using (var graphics = Graphics.FromImage(resized))
                {
                    graphics.CompositingQuality = CompositingQuality.HighSpeed;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.DrawImage(image, 0, 0, width, height);
                    resized.Save($"resized-{imagePath}", ImageFormat.Png);
                    Console.WriteLine($"Saving resized-{imagePath} thumbnail");
                }       
            } 
            Console.WriteLine("Hello World!");
        }
    }
}
