﻿namespace backend.Modelo.Piezas;

public class Reina : IPieza
{
    private Posicion _posicion;
    private Color _color;
    private bool _objetivo;

    public Reina(Posicion posicion, Color color)
    {
        _posicion = posicion;
        _color = color;
        _objetivo = false;
    }

    public void Mover(Posicion posicion)
    {
        _posicion = posicion;
    }

    public List<Posicion?>? Movimientos(IPieza[,] tablero)
    {
        List<Posicion?>? mov = new List<Posicion?>();

        for (int i = 1; i < 8; i++)
        {
            /*mov.Add(Posicion.CrearPosicionValida(_posicion.X + i, _posicion.Y));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X - i, _posicion.Y));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y + i));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X, _posicion.Y - i));
        
            mov.Add(Posicion.CrearPosicionValida(_posicion.X+i,_posicion.Y+i));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X+i,_posicion.Y-i));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X-i,_posicion.Y+i));
            mov.Add(Posicion.CrearPosicionValida(_posicion.X-i,_posicion.Y-i));*/ 
        }
        
        mov.RemoveAll(item => item == null);
        return mov;
    }

    public string TipoPiezaUniCode()
    {
        if ( _color== Color.Blanco)
        {
            return "\u2655";
        }
        else
        {
            return "\u265B";
        }
    }

    public Color CualColor()
    {
        return _color;
    }

    public bool EsObjetivo()
    {
        return _objetivo;
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

    public bool Objetivo
    {
        get => _objetivo;
        set => _objetivo = value;
    }
}