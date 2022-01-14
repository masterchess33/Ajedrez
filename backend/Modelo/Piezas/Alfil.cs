namespace backend.Modelo.Piezas;

public class Alfil : IPieza
{
    private Posicion _posicion;
    private Color _color;

    public Alfil(Posicion posicion, Color color)
    {
        _posicion = posicion;
        _color = color;
    }

    public void Mover(Posicion posicion)
    {
        _posicion = posicion;
    }

    public List<Posicion?> Movimientos(IPieza[,] tablero)
    {
        List<Posicion?> mov = new List<Posicion?>();
        
        // Se verifican los movimientos posibles en las cuatro direcciones en diagonal.
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X + i, _posicion.Y + i))
            {
                if (tablero[_posicion.X + i, _posicion.Y + i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y + i));
                }
                else if (tablero[_posicion.X + i, _posicion.Y + i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y + i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X + i, _posicion.Y - i))
            {
                if (tablero[_posicion.X + i, _posicion.Y - i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y - i));
                }
                else if (tablero[_posicion.X + i, _posicion.Y - i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X + i, _posicion.Y - i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X - i, _posicion.Y + i))
            {
                if (tablero[_posicion.X - i, _posicion.Y + i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y + i));
                }
                else if (tablero[_posicion.X - i, _posicion.Y + i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y + i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(_posicion.X - i, _posicion.Y - i))
            {
                if (tablero[_posicion.X - i, _posicion.Y - i] == null!)
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y - i));
                }
                else if (tablero[_posicion.X - i, _posicion.Y - i].ColorPieza() != ColorPieza())
                {
                    mov.Add(new Posicion(_posicion.X - i, _posicion.Y - i));
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        
        return mov;
    }
    
    public Color ColorPieza()
    {
        return _color;
    }

    public string TipoPieza()
    {
        return "Alfil";
    }
    
    public string TipoPiezaUniCode()
    {
        if ( _color== Color.Blanco)
        {
            return "\u2657";
        }
        else
        {
            return "\u265D";
        }
    }

    public Posicion Posicion
    {
        get => _posicion;
        set => _posicion = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public Color Color
    {
        get => _color;
        set => _color = value;
    }
}