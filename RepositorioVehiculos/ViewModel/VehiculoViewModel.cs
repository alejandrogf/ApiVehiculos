using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class VehiculoViewModel:IViewModel<Vehiculo>
    {
        public int idVechiculo { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Coste { get; set; }
        public int Tipo { get; set; }

        public Vehiculo ToBaseDatos()
        {
            return new Vehiculo();
        }

        public void FromBaseDatos(Vehiculo modelVehiculo)
        {
            idVechiculo = modelVehiculo.idVechiculo;
            Matricula = modelVehiculo.Matricula;
            Marca = modelVehiculo.Marca;
            Modelo = modelVehiculo.Modelo;
            Coste = modelVehiculo.Coste;
            Tipo = modelVehiculo.Tipo;
        }

        public void UpdateBaseDatos(Vehiculo modelVehiculo)
        {
            modelVehiculo.idVechiculo = idVechiculo;
            modelVehiculo.Matricula = Matricula;
            modelVehiculo.Marca = Marca;
            modelVehiculo.Modelo = Modelo;
            modelVehiculo.Coste = Coste;
            modelVehiculo.Tipo = Tipo;
        }

        public object[] Getkeys()
        {
            return new object[] {idVechiculo};
        }
    }
}
