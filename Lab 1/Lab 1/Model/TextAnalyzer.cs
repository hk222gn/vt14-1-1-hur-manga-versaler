using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_1
{
    public class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            int capitals = 0;

            foreach (char capital in text)
            {
                if (char.IsUpper(capital))
                {
                capitals += 1;
                }
            }

            return capitals;
        }

    }
}