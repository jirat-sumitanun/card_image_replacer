using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace illusion_image_replacer
{
    class illusion_utils_class
    {
        public static void createNewCard(string cardImagePath, string replaceImagePath, string savePath)
        {
            string[] accept_ext = { ".png", ".jpg", ".jpeg", ".jiff" };
            for (int i = 0; i < accept_ext.Length; i++)
            {
                if(Path.GetExtension(replaceImagePath) == accept_ext[i])
                {
                    if (accept_ext[i] != ".png")
                    {
                        //string convert_image_path = convertToPNG(replaceImagePath);
                        convertToPNG(replaceImagePath, savePath);
                        //saveNewCard(cardImagePath, replaceImagePath, savePath);
                        saveToConvert(cardImagePath, savePath);
                        //File.Delete(convert_image_path);
                    }
                    else
                    {
                        //File.Copy(replaceImagePath, savePath);
                        saveNewCard(cardImagePath, replaceImagePath, savePath);
                    }
                }
            }
        }
        public static void saveNewCard(string cardImagePath, string replaceImagePath,string savePath)
        {
            byte[] bytesToSearch = Encoding.UTF8.GetBytes("IEND");
            byte[] cardImage = File.ReadAllBytes(cardImagePath);
            byte[] replaceImage = File.ReadAllBytes(replaceImagePath);
            //Console.WriteLine($"byteToSearch {bytesToSearch.Length}\ncardImage {cardImage.Length}\nreplaceImage {replaceImage.Length}");
            int indexCardImage = search(cardImage, bytesToSearch);
            byte[] card_data = new byte[cardImage.Length - (indexCardImage+8)];
            System.Buffer.BlockCopy(cardImage, indexCardImage + 8, card_data, 0, cardImage.Length - (indexCardImage + 8));
            //writeNewCard(card_data, savePath);
            
            //int indexReplaceImage = search(replaceImage, bytesToSearch);

            //int newCardArraySize = (cardImage.Length - (indexCardImage + 8)) + (indexReplaceImage+8);
            int newCardArraySize = card_data.Length + replaceImage.Length;
            byte[] newCard = new byte[newCardArraySize];
            System.Buffer.BlockCopy(replaceImage,0,newCard,0,replaceImage.Length);
            //System.Buffer.BlockCopy(cardImage, indexCardImage + 8, newCard, indexReplaceImage + 8,cardImage.Length - (indexCardImage +8));
            System.Buffer.BlockCopy(card_data, 0, newCard, replaceImage.Length, card_data.Length);
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
        public static void saveToConvert(string cardImagePath, string savePath)
        {
            byte[] bytesToSearch = Encoding.UTF8.GetBytes("IEND");
            byte[] cardImage = File.ReadAllBytes(cardImagePath);
            byte[] replaceImage = File.ReadAllBytes(savePath);
            int indexCardImage = search(cardImage, bytesToSearch);
            byte[] card_data = new byte[cardImage.Length - (indexCardImage + 8)];
            System.Buffer.BlockCopy(cardImage, indexCardImage + 8, card_data, 0, cardImage.Length - (indexCardImage + 8));
            int newCardArraySize = card_data.Length + replaceImage.Length;
            byte[] newCard = new byte[newCardArraySize];
            System.Buffer.BlockCopy(replaceImage, 0, newCard, 0, replaceImage.Length);
            System.Buffer.BlockCopy(card_data, 0, newCard, replaceImage.Length, card_data.Length);
            File.Delete(savePath);
            writeNewCard(newCard, savePath);
            
        }
        public static void extractImage(string filePath)
        {
            byte[] bytesArray = File.ReadAllBytes(filePath);
            byte[] bytes = Encoding.UTF8.GetBytes("IEND");
            int idx = search(bytesArray, bytes);
            byte[] pngImageSection = new byte[idx + 8];
            System.Buffer.BlockCopy(bytesArray, 0, pngImageSection, 0, idx + 8);
            string date_extract = DateTime.Now.ToString("yyyyMMddHHmmssfffffff");
            string path_to_save = Path.Combine(createExtractFolder(), "extract_" + date_extract + ".png");
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

        public static void convertToPNG(string replace_image, string savePath)
        {
            Image image = Image.FromFile(replace_image);
            //string savePath = Path.Combine(Path.GetDirectoryName(replace_image),$"{Path.GetFileNameWithoutExtension(replace_image)}_temp.png");
            //Console.WriteLine(savePath);
            image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
            //return savePath;
            
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
