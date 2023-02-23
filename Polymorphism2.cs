using System;

public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     
     familydata ayahku = new familydata("Agus Wahyudi",50,+6282345677708);
    familydata ibuku = new familydata("Yulia Huda",48,+6282345678558);
    familydata aku = new familydata("M Sofiyan Wahyudi",17,+6281359515320);
     Console.WriteLine("data ayah:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("data ibu:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("data anak:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
     
        

    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
       
        
        
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Travelling");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("menjahit");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bermain game");
        }
    }
    

}
