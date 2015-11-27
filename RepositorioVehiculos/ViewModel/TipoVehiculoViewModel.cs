using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class TipoVehiculoViewModel:IViewModel<Tipo>
    {
        public int idTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Tipo ToBaseDatos()
        {
            return new Tipo();
        }

        public void FromBaseDatos(Tipo modeloTipo)
        {
            idTipo = modeloTipo.idTipo;
            Nombre = modeloTipo.Nombre;
            Descripcion = modeloTipo.Descripcion;
        }

        public void UpdateBaseDatos(Tipo modeloTipo)
        {
            modeloTipo.idTipo = idTipo;
            modeloTipo.Nombre = Nombre;
            modeloTipo.Descripcion = Descripcion;
        }

        public object[] Getkeys()
        {

            return new object[] {idTipo};



        }
    }
}
