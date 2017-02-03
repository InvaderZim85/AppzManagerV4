using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppzManagerV4.Images
{
    public static class ImageManager
    {
        /// <summary>
        /// Returns a list of all image files
        /// </summary>
        /// <returns>List of image files</returns>
        public static Dictionary<string, Image> GetImages()
        {
            var result = new Dictionary<string, Image>();
            foreach (DictionaryEntry image in ImageFiles.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, false))
            {
                result.Add(image.Key.ToString(), (Image)image.Value);
            }
            return result;
        }
    }
}
