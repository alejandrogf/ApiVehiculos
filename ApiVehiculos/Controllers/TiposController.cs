using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;

namespace ApiVehiculos.Controllers
{
    //CORS se activa siempre para todos los controladores. 
    //Si tienes un controller Base, con ponerlo ahi sirve

        [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TiposController : ApiController
    {
        
        //Siempre el de Microsoft.Practices.Unity
        [Dependency]
        public  IRepositorio<Tipo, TipoVehiculoViewModel> Repositorio { get; set; }

        public ICollection<TipoVehiculoViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof (TipoVehiculoViewModel))]
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        [ResponseType(typeof (TipoVehiculoViewModel))]
        public IHttpActionResult NuevoTipo(TipoVehiculoViewModel model)
        {
            var data = Repositorio.Add(model);
            if (data == null)
            {
                return BadRequest("Error al crear el objeto.");
            }
            model.idTipo = data.idTipo;

            return Created("ApiVehiculos", data);
        }
    }
}
