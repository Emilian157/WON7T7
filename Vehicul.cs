using System;
class Vehicul
{
    // Proprietati masina
    public string Marca { get; set; }
    public string Model { get; set; }
    public int AnDeFabricatie { get; set; }
    public int CapacitateCilindrica { get; set; }
    public string Combustibil { get; set; }
    public int Putere { get; set; }
    public int NumarUsi { get; set; }

    // Constructor
    public Vehicul(string marca, string model, int anDeFabricatie, int capacitateCilindrica, string combustibil, int putere, int numarUsi)
    {
        Marca = marca;
        Model = model;
        AnDeFabricatie = anDeFabricatie;
        CapacitateCilindrica = capacitateCilindrica;
        Combustibil = combustibil;
        Putere = putere;
        NumarUsi = numarUsi;
    }

    // Metoda pentru a obtine descrierea vehicul
    public string GetDescription()
    {
        return $"{Marca}, {Model}, {AnDeFabricatie}, {CapacitateCilindrica}cc, {Combustibil}, {Putere}CP, {NumarUsi} usi";
    }
}