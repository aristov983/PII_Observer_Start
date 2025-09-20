using System.Data;

namespace Ucu.Poo.Observer;

public interface IObserver<T>
{
    void Update(T valor);
}