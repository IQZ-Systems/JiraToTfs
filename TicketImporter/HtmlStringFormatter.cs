using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicketImporter
{
    public class HtmlStringFormatter
    {
        public static string FindHrefs(string input)
        {
            Regex regex = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase);
            string inputTmp = input;
            Match match;
            for (match = regex.Match(inputTmp) ; match.Success ; match = match.NextMatch())
            {
                foreach (Group group in match.Groups)
                {
                    LoggerUtil.WriteInLog("Group value: {0}" + group.ToString());
                    if (group.ToString().Contains("ViewProfile"))
                    {
                        string[] split = group.ToString().Split('=');
                        if (split.Length >= 2)
                        {
                            input = input.Replace(group.ToString(), " class='mention-preview-person mention-preview-me' ");
                        }
                    }
                }
            }
            return input;
        }
    }
}
