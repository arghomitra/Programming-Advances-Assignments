using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _02_Space;

namespace Module_02
{
    public class Assignment
    {
        public string Space(string input)
        {
            
            string output = string.Empty;
            Dictionary<int, string> signals = new Dictionary<int, string>();

            string[] lines = input.Trim().Split('\n');
            foreach (string line in lines)
            {
                string message = line;

                string pettern = "\".*\"";
                Regex rx = new Regex($@"{pettern}");
                MatchCollection matches = rx.Matches(message);
                string fragment = matches[0].ToString().Replace('"', ' ').Trim();

                Regex rx2 = new Regex(@"\d");
                MatchCollection matches2 = rx2.Matches(message);
                int ts = Convert.ToInt32(matches2[0].ToString());
                signals.Add(ts, fragment);



            }
            foreach (var signal in signals.OrderBy(key => key.Key))
            {
                output +=signal.Value + " ";
            }


            return output.Trim();
        }
    }
}
