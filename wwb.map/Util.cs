using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class Util
    {
        public static string Format(string fm, params object[] args)
        {
            string rtn = fm;
            for(int i =0;i<args.Length;i++)
            {
                if (args[i].ToString().ToLower().Equals("true") || args[i].ToString().ToLower().Equals("false"))
                {
                    args[i] = args[i].ToString().ToLower();
                }
                rtn = rtn.Replace("{"+i+"}", args[i].ToString());
            }
            return rtn;
        }

    }
}
