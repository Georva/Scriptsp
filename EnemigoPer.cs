using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPer : Persecucion
{
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // se refiere que puedes compartir informacion a cualquier objeto
        Perseguir(playerPosition, this.gameObject.transform);
    }
}
