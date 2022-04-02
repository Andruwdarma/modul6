namespace modul6_kelompok_6PM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa1302204105 mahasiswa = new DataMahasiswa1302204105();
            mahasiswa.ReadJSON();
            TeamMembers1302204105 tim = new TeamMembers1302204105();
            tim.ReadJSON();
        }
    }
}