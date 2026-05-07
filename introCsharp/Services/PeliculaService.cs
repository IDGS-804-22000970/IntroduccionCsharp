using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCsharp.Services
{
    public List <Pelicula> ObtenerPelicula()
    {
        var pelicula1 = new Pelicula()
        {
            Titulo = "Superman",
            Duracion = 120,
            Pais = "USA",
            Publicacion = new DateTime(2013, 12, 5)
        };
        var pelicula2 = new Pelicula()
        {
            Titulo = "Spider Man",
            Duracion = 111,
            Pais = "USA",
            Publicacion = new DateTime(2015, 11, 2)
        };
        return new List<Pelicula> { pelicula1, pelicula2 }
}