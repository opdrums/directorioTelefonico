using System.IO;
using Avalonia.Media.Imaging;

namespace DirectorioTelefonico.Utils
{
    public static class ImagenHelper
    {
        public static byte[]? ToBytes(Bitmap? imagen)
        {
            if (imagen == null) return null;
            using MemoryStream ms = new MemoryStream();
            imagen.Save(ms);
            return ms.ToArray();
        }

        public static Bitmap? FromBytes(byte[]? data)
        {
            if (data == null) return null;
            using MemoryStream ms = new MemoryStream(data);
            return new Bitmap(ms);
        }
    }
}
