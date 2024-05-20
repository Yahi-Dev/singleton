namespace POO
{
    class Prueba
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese la especie de la mascota: ");
            string specieMascota = Console.ReadLine()!;

            System.Console.WriteLine("Ingrese el nombre de la mascota: ");
            string nameMascota = Console.ReadLine()!;

            //Pedir el apellido Familia

            Mascota mascota = Mascota.GetMascota(specieMascota, nameMascota);
            Familia familia = new Familia("Martinez",mascota);
        }
    }
}