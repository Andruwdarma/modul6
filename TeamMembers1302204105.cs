using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_6PM
{
    internal class TeamMembers1302204105
    {
        public void ReadJSON()
        {
            string dataStr = File.ReadAllText(@"C:\Users\orval\Documents\Kuliah\KPL\modul6\jurnal6_2_1302204105.json");
            dynamic data = JsonConvert.DeserializeObject(dataStr);
            Console.WriteLine("JSON 2");
            foreach (var item in data.members)
            {
                Console.WriteLine(item.nim + " "+ item.firstName + " " + item.lastName + "("+ item.age+" "+item.gender+")");
                /*Console.WriteLine("NAMA             : " + item.firstName + " " + item.lastName);
                Console.WriteLine("Jenis Kelamin    : " + item.gender);
                Console.WriteLine("USIA             : " + item.age);*/
            }
            Console.WriteLine();
        }
    }
}
