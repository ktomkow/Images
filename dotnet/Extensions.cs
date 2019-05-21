using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Advanced;
using System;
using System.IO;
using System.Text;

namespace dotnet
{
    public static class Extensions
    {
        public static void SaveAsPgm(this Image<Rgba32> image, string name)
        {
            int width = image.Width;
            int height = image.Height;

            var path = $"../processedImages/dotnet/{name}/.pgm";
            var builder = new StringBuilder();

            FileStream fileStream = new FileStream(path, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine("P2");
                writer.WriteLine("# Created with ImageSharp");
                writer.WriteLine($"{width} {height}");
                writer.WriteLine(255);
                for (int i = 0; i < height; i++)
                {
                    builder.Clear();
                    for (int j = 0; j < width; j++)
                    {
                        builder.Append($"{image[j,i].R} ");
                    }
                    writer.WriteLine(builder.ToString());
                }
            }
        }

        public static void ConvertToGray(this Image<Rgba32> image)
        {
            image.Mutate(x => x.Grayscale());
        }

        public static void Resize(this Image<Rgba32> image, int width = 32, int height = 32)
        {
            image.Mutate(x => x.Resize(width, height));
        }
    }
}