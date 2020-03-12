using system;

namespace Agencia.Dominio;
{
    public class Agencia
    {
        public Guid id {get; set;}
        public Modelo Modelo {get; set;}
        public Marca Marca {get; set;}
        public string Nombre {get; set;}

        public Agencia ()
        {
            
        }
        public IList<Marca> Marcas {get; set;} = new IList<Marca>();
        public IList<Modelo> Modelos {get; set;} = new IList<Modelo>();

        public Agencia(string nombre, Modelo modelo, Agencia agencia)
        {
            Id = Guid.newGuid();
            Nombre = nombre;
            Modelo = modelo;
            Marca = new List<Marca>();
        } 
    }
}