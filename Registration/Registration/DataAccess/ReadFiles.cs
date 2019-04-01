using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration.DataAccess
{
    public class ReadFiles<T>
    {

        private readonly string subfoldername = @"DataAccess/MockData";


        public T[] Get(string fileName)
        {

            var exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;


            List<T> list = new List<T>();
            using (StreamReader r = new StreamReader(appRoot + subfoldername + fileName))
            {
                string json = r.ReadToEnd();
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            }
            return list.ToArray();
        }

    }
}
