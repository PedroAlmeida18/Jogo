using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controla_Poder : MonoBehaviour
{
    public GameObject Poder ;
    public GameObject Inimigo; 
    private Collision2D collision2DPoder;


    void Start()
    {
        collision2DPoder = Poder.GetComponent<Collision2D>();
        Poder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AcompanhaMouse();
        //OnCollisionEnter2D(collision2DPoder);
        
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o collider que colidiu tem a tag "Inimigo"
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(collision.gameObject);
        } 
        

        }
private void AcompanhaMouse(){
         Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Poder.transform.position = worldPosition;
    }
}

