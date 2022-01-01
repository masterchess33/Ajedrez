namespace backend.Modelo;

public class Posicion
{
    private int _x;
    private int _y;


    public Posicion(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static bool CrearPosicionValida(int x, int y)
    {
        try
        {
            Posicion n = new Posicion(x, y);
            return true;
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }
    }

    public int X
    {
        get => _x;
        set
        {
            if (value < 0 || value > 7)
            {
                throw new IndexOutOfRangeException("los Valores deben estar entre 0 y 7");
            }
            else
            {
                _x = value;
            }
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0 || value > 7)
            {
                throw new IndexOutOfRangeException("los Valores deben estar entre 0 y 7");
            }
            else
            {
                _y = value;
            }
        }
    }
}