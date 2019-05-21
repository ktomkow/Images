using System;
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

            Image<Rgba32> image;

            for (int i = 0; i <= lastIndex; i++)
            {
                // image = Image.Load(imagePath);
            }

            // var image = Image.Load(imagePath);
            // using (Image<Rgba32> image = Image.Load(imagePath))
            // {
            //     image.Mutate(x => x
            //         // .Resize(image.Width / 2, image.Height / 2)
            //         .Resize(800, 600)
            //         .Grayscale());
            //     // image.Save("here.jpg"); // Automatic encoder selected based on extension.
            //     // image.Sav
            //     image.SaveAsPgm("here.pgm");
            // }

            Console.WriteLine("Hello World!");
        }
    }
}
