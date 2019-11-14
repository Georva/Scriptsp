using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoB : MonoBehaviour
{
    public List<Enemigo> enemigo;

    // Start is called before the first frame update
    void Awake()
    {
        enemigo.Add(new Enemigo(100, 50, "Bolita fuego"));
        enemigo.Add(new Enemigo(200, 500, "slime de marihuana"));
        enemigo.Add(new Enemigo(300, 50, "Muerto de hambre"));
        enemigo.Add(new Enemigo(100, 1000, "Perro malo"));
    }
    // Update is called once per frame
    void Update()
    {

    }
}
