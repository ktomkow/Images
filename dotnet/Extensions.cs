using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Advanced;
using System;

namespace dotnet
{
    public static class Extensions
    {
        public static void SaveAsPgm(this Image<Rgba32> image, string path)
        {
            int width = image.Width;
            int height = image.Height;
            System.Console.WriteLine($"{width} / {height}");

            for (int y = 0; y < image.Height; y++)
            {
                Span<Rgba32> pixelRowSpan = image.GetPixelRowSpan(y);
                for (int x = 0; x < image.Width; x++)
                {
                    pixelRowSpan[x] = new Rgba32(x/255, y/255, 50, 255);
                    System.Console.WriteLine($"{x} : {y}");
                }
            }
        }
    }
}