using System;
class Motor
{
    // Proprietati motor
    public int CapacitateCilindrica { get; set; }
    public int Putere { get; set; }
    public string Combustibil { get; set; }

    // Constructorul
    public Motor(int capacitateCilindrica, int putere, string combustibil)
    {
        CapacitateCilindrica = capacitateCilindrica;
        Putere = putere;
        Combustibil = combustibil;
    }

    // Metoda pentru pornirea motorului
    public void Porneste()
    {
        Console.WriteLine("brr");
    }

    // Metoda pentru oprirea motorului
    public void Opreste()
    {
        Console.WriteLine("par poc pac");
    }
}