using Sitronics;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        var paths = Directory.GetFiles("..\\..\\..\\Content");
        var result = "";

        Coordinates coords;

        foreach (var path in paths)
        {
            Bitmap bitmap = new Bitmap(path);
            coords = ImageReader.GetCenterOfInput(bitmap);
            if(coords != null)
            {
                result += $"{Path.GetFileNameWithoutExtension(path)},{coords.x},{coords.y};";
            }
        }

        Console.WriteLine(result);

    }
}