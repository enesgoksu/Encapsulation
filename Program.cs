namespace Encapsulation.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriniGetir();

            Console.WriteLine("**************************");

            Ogrenci ogrenci1 = new Ogrenci(); // ==  Ogrenci ogrenci1 = new Ogrenci("Arda","Güler",145,2);
            ogrenci1.Isim = "Arda";     
            ogrenci1.Soyisim = "Güler";
            ogrenci1.OgrenciNo = 145;             
            ogrenci1.Sinif = 2;
            ogrenci1.SinifDüsür();
            ogrenci1.SinifDüsür();

            ogrenci1.OgrenciBilgileriniGetir();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get { return isim; } 
            set { isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if (value < 1 )
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                sinif = value;
            } 
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgiler *****");
            Console.WriteLine("Öğrenci adı          :{0}",this.Isim);
            Console.WriteLine("Öğrenci soyadı       :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci Numarası     :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı    :{0}",this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDüsür()
        {
            this.Sinif = this.Sinif - 1;
        }

                        
         
    }
}