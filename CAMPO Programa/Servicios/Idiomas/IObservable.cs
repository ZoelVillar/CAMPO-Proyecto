using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Idiomas
{
    public interface IObservable
    {
        void AgregarObservador(IObserver observador);
        void EliminarObservador(IObserver observador);
        void NotificarObservadores();
        
    }
}
