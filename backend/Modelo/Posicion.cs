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

    public static bool PosicionValida(int x, int y)
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

    public static char? Letra(int numero)
    {
        switch (numero)
        {
            case 0:
                return 'A';
            case 1:
                return 'B';
            case 2:
                return 'C';
            case 3:
                return 'D';
            case 4:
                return 'E';
            case 5:
                return 'F';
            case 6:
                return 'G';
            case 7:
                return 'H';
            default:
                return null;
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