using backend.Modelo.Piezas;

namespace backend.Modelo;

public class Tablero
{
    private IPieza[,] _mesa;
    private const bool Direccionjugador1 = true;
    private const bool Direccionjugador2 = false;
    public Tablero()
    {
        _mesa = new IPieza[8,8];
    }
    
    public Tablero(bool jugador)
    {
        var jugador1 = Color.Negro;
        var jugador2 = Color.Blanco;

        if (jugador)
        {
            jugador1 = Color.Blanco;
            jugador2 = Color.Negro;
        }

        // Se inicializa el tablero
        _mesa = new IPieza[8, 8];

        // Peones 
        for (int i = 0; i < 8; i++)
        {
            _mesa[i, 6] = new Peon(new Posicion(i, 6), jugador2, Direccionjugador2);
            _mesa[i, 1] = new Peon(new Posicion(i, 1), jugador1, Direccionjugador1);
        }

        // caballos
        _mesa[1, 7] = new Caballo(new Posicion(1, 7), jugador2);
        _mesa[1, 0] = new Caballo(new Posicion(1, 0), jugador1);
        _mesa[6, 7] = new Caballo(new Posicion(1, 7), jugador2);
        _mesa[6, 0] = new Caballo(new Posicion(1, 0), jugador1);

        // Alfiles
        _mesa[2, 7] = new Alfil(new Posicion(2, 7), jugador2);
        _mesa[5, 7] = new Alfil(new Posicion(5, 7), jugador2);
        _mesa[2, 0] = new Alfil(new Posicion(2, 0), jugador1);
        _mesa[5, 0] = new Alfil(new Posicion(5, 0), jugador1);

        // Torres
        _mesa[0, 7] = new Torre(new Posicion(0, 7), jugador2);
        _mesa[7, 7] = new Torre(new Posicion(7, 7), jugador2);
        _mesa[0, 0] = new Torre(new Posicion(0, 0), jugador1);
        _mesa[7, 0] = new Torre(new Posicion(7, 0), jugador1);

        // Rey y reina
        _mesa[3, 7] = new Reina(new Posicion(3, 7), jugador2);
        _mesa[3, 0] = new Reina(new Posicion(3, 0), jugador1);

        _mesa[4, 7] = new Rey(new Posicion(4, 7), jugador2);
        _mesa[4, 0] = new Rey(new Posicion(4, 0), jugador1);

    }

    /// <summary>
    /// Metodo que verifica si el rey esta en jaque.
    /// </summary>
    /// <param name="reyPos"></param>
    /// <param name="color"></param>
    /// <returns>True si se encuentra en jaque</returns>
    public bool Jaque(Posicion reyPos, Color color)
    {
        
        // Se ejecutan 4 for loops para verificar posibles jaques en las 4 direcciones horizontales.
        // Primero hacia la izquierda
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X - i, reyPos.Y) && _mesa[reyPos.X - i, reyPos.Y] != null!)
            {
                if (_mesa[reyPos.X - i, reyPos.Y].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X - i, reyPos.Y].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X - i, reyPos.Y].TipoPieza() == "Reina")
                    {
                        Console.WriteLine("hola isquierda {0}",i);
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        // Hacia la derecha
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X + i, reyPos.Y) && _mesa[reyPos.X + i, reyPos.Y] != null!)
            {
                if (_mesa[reyPos.X + i, reyPos.Y].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X + i, reyPos.Y].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X + i, reyPos.Y].TipoPieza() == "Reina")
                    {
                        Console.WriteLine("hola derecha {0}",i);
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        // Hacia arriba
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X, reyPos.Y + i) && _mesa[reyPos.X, reyPos.Y + i] != null!)
            {
                if (_mesa[reyPos.X, reyPos.Y + i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X, reyPos.Y + i].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X, reyPos.Y + i].TipoPieza() == "Reina")
                    {
                        Console.WriteLine("hola arriba {0}",i);
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        // Por ultimo hacia abajo
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X, reyPos.Y - i) && _mesa[reyPos.X, reyPos.Y - i] != null!)
            {
                if (_mesa[reyPos.X, reyPos.Y - i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X, reyPos.Y - i].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X, reyPos.Y - i].TipoPieza() == "Reina")
                    {
                        Console.WriteLine("hola abajo {0}",i);
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        // Se verifican la posiciones en diagonal.
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X + i, reyPos.Y + i) && _mesa[reyPos.X + i, reyPos.Y + i] != null!)
            {
                if (_mesa[reyPos.X + i, reyPos.Y + i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X + i, reyPos.Y + i].TipoPieza() == "Alfil" ||
                        _mesa[reyPos.X + i, reyPos.Y + i].TipoPieza() == "Reina")
                    {
                        Console.WriteLine("hola + + {0}",i);
                        return true;
                    }
                    else if (i == 1 && _mesa[reyPos.X + i, reyPos.Y + i].TipoPieza() == "Peon")
                    {
                        Peon p = (Peon) _mesa[reyPos.X + i, reyPos.Y + i];
                        if (p.Direccion == false)
                        {
                            Console.WriteLine(" {0}",i);
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X + i, reyPos.Y - i) && _mesa[reyPos.X + i, reyPos.Y - i] != null!)
            {
                if (_mesa[reyPos.X + i, reyPos.Y - i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X + i, reyPos.Y - i].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X + i, reyPos.Y - i].TipoPieza() == "Reina")
                    {
                        return true;
                    }
                    else if (i == 1 && _mesa[reyPos.X + i, reyPos.Y - i].TipoPieza() == "Peon")
                    {
                        Peon p = (Peon) _mesa[reyPos.X + i, reyPos.Y - i];
                        if (p.Direccion)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X - i, reyPos.Y + i) && _mesa[reyPos.X - i, reyPos.Y + i] != null!)
            {
                if (_mesa[reyPos.X - i, reyPos.Y + i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X - i, reyPos.Y + i].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X - i, reyPos.Y + i].TipoPieza() == "Reina")
                    {
                        return true;
                    }
                    else if (i == 1 && _mesa[reyPos.X - i, reyPos.Y + i].TipoPieza() == "Peon")
                    {
                        Peon p = (Peon) _mesa[reyPos.X - i, reyPos.Y + i];
                        if (!p.Direccion)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Posicion.PosicionValida(reyPos.X - i, reyPos.Y - i) && _mesa[reyPos.X - i, reyPos.Y - i] != null!)
            {
                if (_mesa[reyPos.X - i, reyPos.Y - i].ColorPieza() != color)
                {
                    if (_mesa[reyPos.X - i, reyPos.Y - i].TipoPieza() == "Torre" ||
                        _mesa[reyPos.X - i, reyPos.Y - i].TipoPieza() == "Reina")
                    {
                        return true;
                    }
                    else if (i == 1 && _mesa[reyPos.X - i, reyPos.Y - i].TipoPieza() == "Peon")
                    {
                        Peon p = (Peon) _mesa[reyPos.X - i, reyPos.Y - i];
                        if (p.Direccion)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        // Se verifica los jaques por caballos.
        List<(int, int)> posCaballos = new List<(int, int)>();
        posCaballos.Add((reyPos.X + 2, reyPos.Y + 1));
        posCaballos.Add((reyPos.X + 2, reyPos.Y - 1));
        posCaballos.Add((reyPos.X - 2, reyPos.Y + 1));
        posCaballos.Add((reyPos.X - 2, reyPos.Y - 1));
        posCaballos.Add((reyPos.X - 1, reyPos.Y + 2));
        posCaballos.Add((reyPos.X + 1, reyPos.Y + 2));
        posCaballos.Add((reyPos.X - 1, reyPos.Y - 2));
        posCaballos.Add((reyPos.X + 1, reyPos.Y - 2));
        
        foreach (var posCaballo in posCaballos)
        {
            if (Posicion.PosicionValida(posCaballo.Item1, posCaballo.Item2) && _mesa[posCaballo.Item1, posCaballo.Item2] != null!)
            {
                if (_mesa[posCaballo.Item1, posCaballo.Item2].TipoPieza() == "Caballo" &&
                    _mesa[posCaballo.Item1, posCaballo.Item2].ColorPieza() != color)
                {
                    return true;
                }
            } 
        }
        
        
        return false;
    }

    public bool JaqueMate(Posicion reyPosicion)
    {
        // Solo para evitar error ide
        return true;
    }

    public IPieza[,] Mesa
    {
        get => _mesa;
        set => _mesa = value ?? throw new ArgumentNullException(nameof(value));
    }
}