using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Les_1
{
    class Pars
    {
        public static string Cut(string data)//фун-я для обрезания имени до небходимой даты
        {
            data = data.Substring(data.IndexOf('(') + 1);
            data = data.Substring(0, data.Length - (data.Length - data.IndexOf(')')));
            return data;
        }
        public static string Open(string file, string Name_devise)
        {
            StreamReader reader = new StreamReader(file);
            string line = reader.ReadLine();
            while ((line != null))
            {
                if ((line.Contains(":" + Name_devise + ":")) & (!line.Contains("garbage")))
                {

                    line = (line.Remove(0, line.IndexOf(Name_devise) + Name_devise.Length + 1));
                    break;
                }
                else
                    line = reader.ReadLine();
            }
            if (line == null)
            {
                line = "Устройство не найдено или строка содержит мусорные данные";
            }
            return line;
        }
    }
}
