namespace tpmodul9_103082400009.Models
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
        }
    }
}
