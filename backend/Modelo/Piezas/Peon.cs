namespace backend.Modelo.Piezas;

public class Peon : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _primerMovimiento;
    private bool _direccion;

    public Peon(Posicion posicion, Color color, bool direccion)
    {
        _posicion = posicion;
        _color = color;
        _direccion = direccion;
        _primerMovimiento = true;
    }

    public void Mover(Posicion posicion)
    {
        if (_primerMovimiento)
        {
            _primerMovimiento = false;
        }

        _posicion = posicion;
    }

    public List<Posicion?> Movimientos(IPieza[,] tablero)
    {
        List<Posicion?> mov = new List<Posicion?>();

        if (_primerMovimiento)
        {
            if (!_direccion)
            {
                if (Posicion.PosicionValida(_posicion.X, _posicion.Y - 2) &&
                    tablero[_posicion.X, _posicion.Y - 2] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y - 2));
                }

                if (Posicion.PosicionValida(_posicion.X, _posicion.Y - 1) &&
                    tablero[_posicion.X, _posicion.Y - 1] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y - 1));
                }
                
                // Se verifica si se puede comer una pieza en diagonal
                if (Posicion.PosicionValida(_posicion.X + 1, _posicion.Y - 1) &&
                    tablero[_posicion.X + 1, _posicion.Y - 1] != null!)
                {
                    mov.Add(tablero[_posicion.X + 1, _posicion.Y - 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X + 1, _posicion.Y - 1)
                        : null);
                }

                // Lo mismo en la otra esquina
                if (Posicion.PosicionValida(_posicion.X - 1, _posicion.Y - 1) &&
                    tablero[_posicion.X - 1, _posicion.Y - 1] != null!)
                {
                    mov.Add(tablero[_posicion.X - 1, _posicion.Y - 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X - 1, _posicion.Y - 1)
                        : null);
                }
            }
            else
            {
                if (Posicion.PosicionValida(_posicion.X, _posicion.Y + 2) &&
                    tablero[_posicion.X, _posicion.Y + 2] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y + 2));
                }

                if (Posicion.PosicionValida(_posicion.X, _posicion.Y + 1) &&
                    tablero[_posicion.X, _posicion.Y + 1] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y + 1));
                }
                
                // Se verifica si se puede comer una pieza en diagonal
                if (Posicion.PosicionValida(_posicion.X + 1, _posicion.Y + 1) &&
                    tablero[_posicion.X + 1, _posicion.Y + 1] != null!)
                {
                    mov.Add(tablero[_posicion.X + 1, _posicion.Y + 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X + 1, _posicion.Y + 1)
                        : null);
                }

                // Lo mismo en la otra esquina
                if (Posicion.PosicionValida(_posicion.X - 1, _posicion.Y + 1) &&
                    tablero[_posicion.X - 1, _posicion.Y + 1] != null!)
                {
                    mov.Add(tablero[_posicion.X - 1, _posicion.Y + 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X - 1, _posicion.Y + 1)
                        : null);
                }
            }
        }
        else
        {
            if (!_direccion)
            {
                // Movimiento hacia delante
                if (Posicion.PosicionValida(_posicion.X, _posicion.Y - 1) &&
                    tablero[_posicion.X, _posicion.Y - 1] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y - 1));
                }

                // Se verifica si se puede comer una pieza en diagonal
                if (Posicion.PosicionValida(_posicion.X + 1, _posicion.Y - 1) &&
                    tablero[_posicion.X + 1, _posicion.Y - 1] != null!)
                {
                    mov.Add(tablero[_posicion.X + 1, _posicion.Y - 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X + 1, _posicion.Y - 1)
                        : null);
                }

                // Lo mismo en la otra esquina
                if (Posicion.PosicionValida(_posicion.X - 1, _posicion.Y - 1) &&
                    tablero[_posicion.X - 1, _posicion.Y - 1] != null!)
                {
                    mov.Add(tablero[_posicion.X - 1, _posicion.Y - 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X - 1, _posicion.Y - 1)
                        : null);
                }
            }
            else
            {
                // Movimiento hacia delante
                if (Posicion.PosicionValida(_posicion.X, _posicion.Y + 1) &&
                    tablero[_posicion.X, _posicion.Y + 1] == null!)
                {
                    mov.Add(new Posicion(_posicion.X, _posicion.Y + 1));
                }

                // Se verifica si se puede comer una pieza en diagonal
                if (Posicion.PosicionValida(_posicion.X + 1, _posicion.Y + 1) &&
                    tablero[_posicion.X + 1, _posicion.Y + 1] != null!)
                {
                    mov.Add(tablero[_posicion.X + 1, _posicion.Y + 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X + 1, _posicion.Y + 1)
                        : null);
                }

                // Lo mismo en la otra esquina
                if (Posicion.PosicionValida(_posicion.X - 1, _posicion.Y + 1) &&
                    tablero[_posicion.X - 1, _posicion.Y + 1] != null!)
                {
                    mov.Add(tablero[_posicion.X - 1, _posicion.Y + 1].ColorPieza() != ColorPieza()
                        ? new Posicion(_posicion.X - 1, _posicion.Y + 1)
                        : null);
                }
            }
        }

        mov.RemoveAll(item => item == null);
        return mov;
    }

    public String TipoPiezaUniCode()
    {
        if (_color == Color.Blanco)
        {
            return "\u2659";
        }
        else
        {
            return "\u265F";
        }
    }

    public Color ColorPieza()
    {
        return _color;
    }


    public Posicion Posicion
    {
        get => _posicion;
        set => _posicion = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool PrimerMovimiento
    {
        get => _primerMovimiento;
        set => _primerMovimiento = value;
    }

    public Color Color
    {
        get => _color;
        set => _color = value;
    }

    public bool Direccion
    {
        get => _direccion;
        set => _direccion = value;
    }
}