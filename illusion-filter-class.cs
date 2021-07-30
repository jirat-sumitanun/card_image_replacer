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
        public static bool illusion_filter(string filePath)
        {
            if (Path.GetExtension(filePath) == ".png")
            {
                if (illusion_card_check(filePath) == "other")
                {
                    return false;
                }
                else return true;
            }
            else return true;
        }

        public static string illusion_card_check(string filePath)
        {
            var fileString = File.ReadAllText(filePath, Encoding.UTF8);
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
