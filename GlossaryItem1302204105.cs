using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_6PM
{
    internal class GlossaryItem1302204105
    {
        public void ReadJSON()
        {
            string dataStr = File.ReadAllText(@"C:\Users\orval\Documents\Kuliah\KPL\modul6\jurnal6_3_1302204105.json");
            dynamic data = JsonConvert.DeserializeObject(dataStr);
            Console.WriteLine("JSON 3");
            Console.WriteLine(data.glossary.title);
            Console.WriteLine();
        }
    }
}
