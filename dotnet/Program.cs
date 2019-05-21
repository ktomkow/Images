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

            using (Image<Rgba32> image = Image.Load(imagePath))
            {
                image.Mutate(x => x
                    .Resize(image.Width / 2, image.Height / 2)
                    .Grayscale());
                image.Save("here.jpg"); // Automatic encoder selected based on extension.
            }

            Console.WriteLine("Hello World!");
        }
    }
}
