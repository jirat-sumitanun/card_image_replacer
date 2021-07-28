using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace illusion_image_replacer
{
    class illusion_filter_class
    {
        public static void saveNewCard(string filePath)
        {
            byte[] bytesArray = imageToByteArray(filePath);
            byte[] bytes = Encoding.UTF8.GetBytes("IENDฎB`");
            foreach (var item in bytes)
            {
                Console.WriteLine(item);
            }
            var test = GetFirstOccurance(bytes,bytesArray);
            Console.WriteLine(test);
        }
        public static int GetFirstOccurance(byte[] byteToFind, byte[] byteArray)
        {
            return Array.IndexOf(byteArray, byteToFind);
        }

        public static byte[] imageToByteArray(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            Console.WriteLine(bytes);
            //File.WriteAllBytes(@"D:\00 MyWorld\c-sharp\illusion-image-replacer\WriteText.txt", bytes);
            return bytes;
        }
    }

}
