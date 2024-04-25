using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controla_Inimigo : MonoBehaviour
{
     Rigidbody2D rigidbody2D_inimigo;
    Transform transformInimigo;

    public GameObject prefabDoObjeto;
    void Start()
    {
        transformInimigo = GetComponent<Transform>();
        rigidbody2D_inimigo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
