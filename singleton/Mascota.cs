namespace POO
{
    public class Mascota
    {
        private static Mascota mascota;
        private string especieMascota;
        private string nombreMascota;

        private Mascota(string nombre, string especie)
        {
            especieMascota = especie;
            nombreMascota = nombre;
        }

        public static Mascota GetMascota(string name, string specie )
        {
            if (name == null)
            {
                mascota = new Mascota (name, specie);
                return mascota;
            }
            else
            {
                return mascota;
            }
        }
    }
}
