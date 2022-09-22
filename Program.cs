namespace PBO_Praktikum
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Mobil mobil1 = new Agya();
            mobil1.ban = new Michelin();
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Mobil mobil2 = new Avanza();
            mobil2.ban = new Bridgestone();
            //mobil2.NyalakanLampu();
            ((Avanza)mobil2).NyalakanLampu();
            Civic civic1 = new Civic();
            civic1.VtecKickedIn();
            civic1.ban = new Bridgestone();

        }
    }
}

class Ban
{
    public string Merk;

    public Ban(string merk) {this.Merk = merk;}
}

class Bridgestone : Ban {public Bridgestone() : base("Bridgestone"){ }}

class Michelin : Ban {public Michelin() : base("Michelin"){ }}



class Mobil
{
    public Ban ban;
    public string Merk,Tipe;


    public Mobil(string merk, string tipe) { this.Tipe = tipe; this.Merk = merk;}
    

    public void MatikanMesin(){Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} mati");}

    public void NyalakanMesin(){Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} menyala");}
}

class Honda : Mobil
{public Honda(string tipe) : base("Honda", tipe){}}

class Brio : Honda
{public Brio() : base("Brio"){}}

class Civic : Honda
{
    public Civic() : base("Civic"){}

    public void VtecKickedIn()    {Console.WriteLine($"Ngeeeng Wooosh!!!");}
}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe) : base("Daihatsu", tipe){}
}

class Xenia : Daihatsu
{
    public Xenia() : base("Xenia"){}
}
class Ayla : Daihatsu
{
    public Ayla() : base("Ayla"){}
}

class Toyota : Mobil
{
    public Toyota(string tipe) : base("Toyota", tipe){}
}

class Avanza : Toyota
{
    public Avanza() : base("Avanza"){}


    public void NyalakanLampu(){Console.WriteLine($"Lampu mobil {this.Merk} bertipe {this.Tipe} menyala");}
}
class Agya : Toyota
{
    public Agya() : base("Agya"){}
}
class Innova : Toyota
{
    public Innova() : base("Innova"){}
}