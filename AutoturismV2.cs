using System;
class AutoturismV2
{
    // Proprietati
    public string Marca { get; set; }
    public string Model { get; set; }
    public int AnDeFabricatie { get; set; }
    public Motor Motor { get; set; }
    public int NumarUsi { get; set; }
    private Usa[] Usi;

    // Constructor
    public AutoturismV2(string marca, string model, int anDeFabricatie, Motor motor, int numarUsi)
    {
        Marca = marca;
        Model = model;
        AnDeFabricatie = anDeFabricatie;
        Motor = motor;
        NumarUsi = numarUsi;
        Usi = new Usa[numarUsi];
        for (int i = 0; i < numarUsi; i++)
        {
            Usi[i] = new Usa();
        }
    }

    // Metoda pentru descrierea autovehiculului
    public string GetDescription()
    {
        return $"{Marca}, {Model}, {AnDeFabricatie}, {Motor.CapacitateCilindrica}cc, {Motor.Combustibil}, {Motor.Putere}CP, {NumarUsi} usi";
    }

    // Metoda pentru pornirea masinii
    public void PornesteMasina()
    {
        Console.WriteLine("Masina porneste");
        for (int i = 0; i < NumarUsi; i++)
        {
            Usi[i].Inchide();
        }
        Motor.Porneste();
    }

    // Metoda pentru oprirea masinii
    public void OpresteMasina()
    {
        Console.WriteLine("Masina se opreste");
        Motor.Opreste();
        for (int i = 0; i < NumarUsi; i++)
        {
            Usi[i].Deschide();
        }
    }
}