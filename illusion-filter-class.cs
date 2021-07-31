using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace illusion_image_replacer
{
    class illusion_filter_class
    {
        public static string illusion_filter(string filePath)
        {
            string[] exclude_extension = { ".jpg", ".jpeg", ".bmp", ".jiff", ".gif" };
            if (Path.GetExtension(filePath) == ".png")
            {
                if (illusion_card_check(filePath) == "other")
                {
                    return "this image not relate to illusion game";
                }
                else return "true";
            }
            else
            {
                for (int i = 0; i < exclude_extension.Length; i++)
                {
                    if (Path.GetExtension(filePath) == exclude_extension[i]) return "PNG file only";
                }
                return "true";
            };
        }

        public static string illusion_card_check(string filePath)
        {
            var fileString = File.ReadAllText(filePath, Encoding.UTF8);
            //File.WriteAllText("text.txt", fileString); // for filter debug
            // koikatsu check
            if (fileString.Contains("【KStudio】")) // Scene card
            {
                return "scene";
            }
            else if (!fileString.Contains("【KStudio】") && (
                fileString.Contains("【KoiKatuChara】") ||
                fileString.Contains("【KoiKatuCharaS】") ||
                fileString.Contains("【KoiKatuCharaSP】"))) // Character card
            {
                return "chara";
            }
            else if (fileString.Contains("【KoiKatuClothes】")) // Coordinate card
            {
                return "coordinate";
            }
            // Koikatsu Sunshine check
            else if (fileString.Contains("【KoiKatuCharaSun】")) // Character card sunshine
            {
                return "chara_sunshine";
            }
            // AI-Girls & Honey Select2 check
            else if (fileString.Contains("【StudioNEOV2】")) // Scene card
            {
                return "scene";
            }
            else if (!fileString.Contains("【StudioNEOV2】") && (
                fileString.Contains("【AIS_Chara】"))) // Character card
            {
                return "chara";
            }
            else if (fileString.Contains("【AIS_Clothes】")) // Coordinate card
            {
                return "coordinate";
            }
            else // normal png, note relate to game
            {
                return "other";
            }
        }
    }
}
