using system;

namespace Agencia.Dominio; 
{
    public class Modelo
    {
        public Guid Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get,set;}
        public string Sexo {get, set;}
        public double Medidas {get; set;}
        public int Telefono{get, set;}
        //faltaría foto y RRSS
        public Marca marca {get; set;}
        public Agencia agencia {get; set;}

        public Modelo ()
        {

        }

    

        public IList<Agencia> Agencias {get; set;} = new IList<Agencia>();
        public IList<Marca> Marcas {get; set;} = new IList<Marca>();

        public static Modelo Create()
        {
            var modelo = new Modelo();
            {
            Id = Guid.newGuid();
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Medidas = medidas;
            Telefono = telefono;
            Marca = new List<Marca>();
            Agencia = new List<Agencia>();

            }
        }
    }
}