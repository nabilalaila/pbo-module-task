using System;
using System.Collections.Generic;

namespace Tugas_PBO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunBinatang1 = new KebunBinatang();
            Hewan hewan1 = new Hewan("Burung", 5);
            Mamalia Mamalia1 = new Mamalia("Lumba-lumba", 0, 2);
            Reptil reptil1 = new Reptil("Brontosaurus", 10, 100);
            Singa singa1 = new Singa("Sion", 4, 1);
            Gajah gajah1 = new Gajah("Gumussh", 4, 3);
            Ular ular1 = new Ular("Nagini", 6.5, 7);
            Buaya buaya1 = new Buaya("Mantan", 2.5, 6);
            Reptil reptil = new Buaya("Halodek", 1.7, 22);

            kebunBinatang1.TambahHewan(singa1);
            kebunBinatang1.TambahHewan(gajah1);
            kebunBinatang1.TambahHewan(ular1);
            kebunBinatang1.TambahHewan(buaya1);
            kebunBinatang1.DaftarHewan();
            Console.WriteLine();

            Console.WriteLine("Suara Hewan :");
            Console.WriteLine(hewan1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Mamalia :");
            Console.WriteLine(Mamalia1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Reptil:");
            Console.WriteLine(reptil1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Singa :");
            Console.WriteLine(singa1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Gajah :");
            Console.WriteLine(gajah1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Ular :");
            Console.WriteLine(ular1.Suara());
            Console.WriteLine();

            Console.WriteLine("Suara Buaya :");
            Console.WriteLine(buaya1.Suara());
            Console.WriteLine();

            Console.WriteLine("Auman Singa :");
            singa1.Mengaum();
            Console.WriteLine();

            Console.WriteLine("Auman Singa :");
            ular1.Merayap();
            Console.WriteLine();

            Console.WriteLine("Suara buaya bertipe reptil :");
            Console.WriteLine(reptil.Suara());
            Console.WriteLine();

            Console.WriteLine("Info Singa :");
            Console.WriteLine(singa1.Infosinga());
        }
    }

    class Hewan
    {
        public string Nama;
        public int Umur;

        public Hewan(string nama, int umur)
        {
            this.Nama = nama;
            this.Umur = umur;
        }
        public virtual string Suara()
        {
            return "Hewan ini bersuara";
        }

        public string InfoHewan()
        {
            return $"Nama : {Nama} \nUmur : {Umur} Tahun\n";
        }
    }

    class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int JumlahKaki, int umur) : base(nama, umur)
        {
            this.jumlahKaki = JumlahKaki;
        }

        public override string Suara()
        {
            return "Hoooo Aku Mamaliaaa";
        }
    }

    class Reptil : Hewan
    {
        public double PanjangTubuh;

        public Reptil(string nama, double panjangTubuh, int umur) : base(nama, umur)
        {
            this.PanjangTubuh = panjangTubuh;
        }

        public override string Suara()
        {
            return "Hi Everyone, I'm Reptile!!";
        }
    }

    class Singa : Mamalia
    {
        public Singa(string nama, int JumlahKaki, int umur) : base(nama, JumlahKaki, umur)
        {

        }
        public override string Suara()
        {
            return "Raja Hutan nih bos. Senggol dong!";
        }
        public void Mengaum()
        {
            Console.WriteLine("Auuum");
        }

        public string Infosinga()
        {
            return $"{InfoHewan()}Jumlah Kaki : {jumlahKaki}";
        }
            
}

    class Gajah : Mamalia
    {
        public Gajah(string nama, int JumlahKaki, int umur) : base(nama, JumlahKaki, umur)
        {

        }
        public override string Suara()
        {
            return "Minggir bro, nanti keinjak.";
        }
    }

    class Ular : Reptil
    {
        public Ular(string nama, double panjangTubuh, int umur) : base(nama, panjangTubuh, umur)
        {

        }
        public override string Suara()
        {
            return "Mana Harry Potter? Dapet salam dari Voldemort nih.";
        }
        public void Merayap()
        {
            Console.WriteLine("Yap yap yap. Aku merayap");
        }
    }

    class Buaya : Reptil
    {
        public Buaya(string nama, double panjangTubuh, int umur) : base(nama, panjangTubuh, umur)
        {

        }
        public override string Suara()
        {
            return "Seandainya senyummu adalah matahari, dunia ini akan selalu bercahaya setiap hari dek :Love";
        }
    }

    class KebunBinatang
    {
        public List<Hewan> KoleksiHewan;

        public void TambahHewan(Hewan hewan)
        {
            KoleksiHewan.Add(hewan);
        }
        public KebunBinatang()
        {
            KoleksiHewan = new List<Hewan>();
        }
        public void DaftarHewan()
        {
            if (KoleksiHewan.Count == 0)
            {
                Console.WriteLine("Sorry nggak ada hewan nih");
            }
            else
            {
                Console.WriteLine("Ini daftar hewannya: ");
                foreach (var hewan in KoleksiHewan)
                {
                    Console.WriteLine(hewan.InfoHewan());
                }
            }
        }
    }
}
