using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Balbuena Nogues Georva Ivette

[System.Serializable]

public class Armas
{

    //construccion de datos
    public string Nombre;
    public int daño;
    public int municion;
    public int extraporexplocion;


    public Armas(string n, int d)
    {
        this.Nombre = n;
        this.daño = d;
    }

    public Armas (string n,  int daño, int m)
    {
        this.Nombre = n;
        this.daño = daño;
    }

  


}
