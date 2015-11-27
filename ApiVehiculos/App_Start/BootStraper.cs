using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;

namespace ApiVehiculos.App_Start
{
    public class BootStraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, ParqueMotorEntities>();

            container.RegisterType<IRepositorio<Tipo, TipoVehiculoViewModel>, 
                              RepositorioEntity<Tipo, TipoVehiculoViewModel>>();

            container.RegisterType<IRepositorio<Vehiculo, VehiculoViewModel>,
                              RepositorioEntity<Vehiculo, VehiculoViewModel>>();

        }
    }
}
