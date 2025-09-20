namespace Ucu.Poo.Observer;

public class GenericType<T>
{
    private T _valor;

    public GenericType(T valor)
    {
        _valor = valor;
    }

    public T ReturnValue()
    {
        return _valor;
    }

    public void Update(T valor)
    {
        _valor = valor;
    }
}