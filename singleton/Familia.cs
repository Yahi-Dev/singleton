namespace POO
{
    public class Familia
    {
       public string apellidoFamilia;
        public Mascota mascotica {get; set;}

        public Familia (string apellido, Mascota mascotica)
        {
            apellidoFamilia = apellido;
            this.mascotica = mascotica;
        }


    }
}
