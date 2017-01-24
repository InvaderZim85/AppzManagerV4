using System.Collections.Generic;

namespace AppzManagerV4.Global
{
    public static class CustomDelegates
    {
        /// <summary>
        /// Delegate for the asynchron adding of new entries
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="filepathList">The filepath list</param>
        public delegate void NewEntry(GlobalEnums.RegionType region, List<string> filepathList = null);
        /// <summary>
        /// Delegate for the import of legacy data
        /// </summary>
        /// <param name="max">The count of data</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        public delegate void ImportStep(int max, int step, string msg);
    }
}
