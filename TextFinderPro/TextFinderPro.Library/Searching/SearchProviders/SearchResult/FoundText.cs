using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.Searching.SearchProviders.SearchResullt
{
    /// <summary>
    /// Found text with position. Position = -1 of it's uknown, or text doesn't exist in file
    /// </summary>
    public class FoundText
    {
        public const int NotFoundPosition = -1;

        public string Text { get; set; }
        public int Position { get; set; }

        public FoundText(string text, int position = NotFoundPosition)
        {
            Text = text;
            Position = position;
        }
    }
}
