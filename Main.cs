using System;
class Program
{
    static void Main(string[] args)
    {
        //Partea 1

        // Creare vehicul
        Vehicul vehicul1 = new Vehicul("BMW", "Seria 3", 2022, 2000, "Benzina", 190, 4);
        Vehicul vehicul2 = new Vehicul("Audi", "A4", 2020, 1800, "Motorina", 150, 4);

        // Descriere vehicul
        Console.WriteLine("Descrierea vehiculului 1: " + vehicul1.GetDescription());
        Console.WriteLine("Descrierea vehiculului 2: " + vehicul2.GetDescription());

        /////////////////////////////
        Console.WriteLine("/////////////////////////////");
        /////////////////////////////

        //Partea 2

        // Creare motor si autoturismV2
        Motor motor1 = new Motor(2000, 190, "Benzina");
        AutoturismV2 autoturism1 = new AutoturismV2("BMW", "Seria 3", 2022, motor1, 4);

        Motor motor2 = new Motor(1800, 150, "Motorina");
        AutoturismV2 autoturism2 = new AutoturismV2("Audi", "A4", 2020, motor2, 5);

        // Afisare descriere
        Console.WriteLine("Descrierea autoturismuluiV2 1: " + autoturism1.GetDescription());
        Console.WriteLine("Descrierea autoturismuluiV2 2: " + autoturism2.GetDescription());

        // Pornirea si oprirea masinilor
        autoturism1.PornesteMasina();
        autoturism1.OpresteMasina();

        autoturism2.PornesteMasina();
        autoturism2.OpresteMasina();
    }
}