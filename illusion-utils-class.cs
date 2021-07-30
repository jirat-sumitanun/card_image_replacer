using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace illusion_image_replacer
{
    class illusion_utils_class
    {
        public static void saveNewCard(string cardImagePath, string replaceImagePath,string savePath)
        {
            byte[] bytesToSearch = Encoding.UTF8.GetBytes("IEND");
            byte[] cardImage = File.ReadAllBytes(cardImagePath);
            byte[] replaceImage = File.ReadAllBytes(replaceImagePath);
            int indexCardImage = search(cardImage, bytesToSearch);
            int indexReplaceImage = search(replaceImage, bytesToSearch);
            int newCardArraySize = (cardImage.Length - (indexCardImage + 8)) + (indexReplaceImage+8);
            byte[] newCard = new byte[newCardArraySize];
            System.Buffer.BlockCopy(replaceImage,0,newCard,0,indexReplaceImage+8);
            System.Buffer.BlockCopy(cardImage, indexCardImage + 8, newCard, indexReplaceImage + 8,cardImage.Length - (indexCardImage +8));
            writeNewCard(newCard,savePath);
        }

        public static void writeNewCard(byte[] byteToWrite, string savePath) {
            //Data that needs to added, converted to bytes, Better off making a function for this
            //String str = "Data to be added";
            //byte[] newBytes = new byte[str.Length * sizeof(char)];
            //System.Buffer.BlockCopy(str.ToCharArray(), 0, newBytes, 0, newBytes.Length);

            //Add the two byte arrays, the file bytes, the new data bytes
            //byte[] fileBytesWithAddedData = new byte[fileBytes.Length + newBytes.Length];
            //System.Buffer.BlockCopy(fileBytes, 0, fileBytesWithAddedData, 0, fileBytes.Length);
            //System.Buffer.BlockCopy(newBytes, 0, fileBytesWithAddedData, fileBytes.Length, newBytes.Length);

            //Write to new file
            File.WriteAllBytes(savePath, byteToWrite);
        }
        public static void extractImage(string filePath)
        {
            byte[] bytesArray = File.ReadAllBytes(filePath);
            byte[] bytes = Encoding.UTF8.GetBytes("IEND");
            int idx = search(bytesArray, bytes);
            byte[] pngImageSection = new byte[idx + 8];
            System.Buffer.BlockCopy(bytesArray, 0, pngImageSection, 0, idx + 8);
            string path_to_save = Path.Combine(createExtractFolder(), "extract_" + Path.GetFileName(filePath));
            File.WriteAllBytes(path_to_save, pngImageSection);
        }

        public static string createExtractFolder()
        {
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "extract")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "extract"));
            }
            return Path.Combine(Directory.GetCurrentDirectory(), "extract");
        }

        public static int search(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (match(haystack, needle, i))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool match(byte[] haystack, byte[] needle, int start)
        {
            if (needle.Length + start > haystack.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < needle.Length; i++)
                {
                    if (needle[i] != haystack[i + start])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }

}
