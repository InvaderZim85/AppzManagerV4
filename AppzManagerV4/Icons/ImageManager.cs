using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppzManagerV4.Icons
{
    public static class ImageManager
    {
        /// <summary>
        /// Gets all images of the resource file
        /// </summary>
        /// <returns>The dictionary with the images</returns>
        public static Dictionary<string, Image> GetImages()
        {
            var resourceSet = ImageFiles.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, false);
            return resourceSet.OfType<DictionaryEntry>().ToDictionary(entry => entry.Key.ToString(), entry => (Image) entry.Value);
        }
    }
}
