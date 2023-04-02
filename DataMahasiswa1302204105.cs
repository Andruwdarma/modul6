using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;  

namespace modul6_kelompok_6PM
{
    internal class DataMahasiswa1302204105
    {
        public void ReadJSON()
        {
            string dataStr = File.ReadAllText(@"C:\Users\orval\Documents\Kuliah\KPL\modul6\jurnal6_1_1302204105.json");
            dynamic data = JsonConvert.DeserializeObject(dataStr);
            Console.WriteLine("JSON 1");
            Console.WriteLine("NAMA             : " + data.firstName + " " + data.lastName);
            Console.WriteLine("Jenis Kelamin    : " + data.gender);
            Console.WriteLine("USIA             : " + data.age);
            Console.WriteLine("ALAMAT           : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("MATA KULIAH      : ");
            foreach (var item in data.courses)
            {
                Console.WriteLine("Kode matkul  : " + item.code);
                Console.WriteLine("Nama matkul  : " + item.name);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
