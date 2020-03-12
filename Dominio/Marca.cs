using system;

namespace Agencia.Dominio;
{
    public class Marca
    {
        public Guid id {get; set;}
        public Modelo Modelo {get; set;}
        public Agencia Agencia {get; set;}
        public string Nombre {get; set;}

        public Marca ()
        {

        }

        public IList<Modelo> Modelos {get; set;} = new IList<Modelo>();
        public IList<Agencia> Agencias {get; set;} = new IList<Agencia>();

        public Marca(string nombre, Modelo modelo, Agencia agencia)
        {
            Id = Guid.newGuid();
            Nombre = nombre;
            Modelo = modelo;
            Agencia = agencia;
        } 
    }
}