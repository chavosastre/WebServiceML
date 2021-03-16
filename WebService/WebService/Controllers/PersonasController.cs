using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebService.Models;

namespace WebService.Controllers
{
    public class PersonasController : ApiController
    {
        List<Persona> listapersonas = new List<Persona>();

        public PersonasController()
        {
            Persona p = new Persona { IdPersona = 1, Nombre = "Lucia", Email = "lucia@mail.com", Edad = 30 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 2, Nombre = "Juan", Email = "juan@mail.com", Edad = 40 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 3, Nombre = "Motoko", Email = "motoko@mail.com", Edad = 33 };
            this.listapersonas.Add(p);
        }

        //Get api/<controller>
        public List<Persona> GetPersonas()
        {
            return this.listapersonas;
        }

        //Get api/<controller>/9
        public Persona GetPersona(int id)
        {
            Persona p = this.listapersonas.Find(z => z.IdPersona == id);
            return p;
        }
    }
}
