using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Idiomas
{
    public class ObserverVentas : IObservable
    {
        private List<IObserver> observadores = new List<IObserver>();

        public void AgregarObservador(IObserver observador)
        {
            observadores.Add(observador);
        }

        public void EliminarObservador(IObserver observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar();
            }
        }



    }
}
