using System.Collections.Generic;
using CefSharp.DevTools.LayerTree;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public class LeetSpeakPostMod : IPostModStrategy
    {
        private readonly Dictionary<string, string> r_LeetDictionary = new Dictionary<string, string>()
                                                            {
                                                                {"a","4"},
                                                                {"e","3"},
                                                                {"g","6"},
                                                                {"l","1"},
                                                                {"o","0"},
                                                                {"s","5"},
                                                                {"t","7"},
                                                            };
        public string ModifyText(string i_Text, string i_Context)
        {
            string leetText = "";
            foreach(char c in i_Text.ToLower())
            {
                if (r_LeetDictionary.ContainsKey(c.ToString())) 
                    leetText += r_LeetDictionary[c.ToString()];
                else
                    leetText += c;
            }
            return leetText;
        }
    }
}