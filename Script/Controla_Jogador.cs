using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controla_Jogador : MonoBehaviour
{
    Rigidbody2D rigidbody2D_Jogador;
    Transform transformjogador ;
    public float velocidade ;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D_Jogador = GetComponent<Rigidbody2D>();

        transformjogador = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()

    {
        velocidade = 0.25f;
       float eixoX = Input.GetAxis("Horizontal");
        Vector3 novaposicao = new Vector3(eixoX,0,0);
        transformjogador.Translate(novaposicao * velocidade);
    }
}
