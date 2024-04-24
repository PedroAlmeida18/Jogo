using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Controla_interface : MonoBehaviour
{
    public GameObject Poder ;
    public UnityEngine.UI.Button botao;
    void Start()
    {
        Poder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(){
        if(!Poder.activeSelf){
            Poder.SetActive(true);
        
        } 
        if(Poder.activeSelf){
            Destroy(botao.gameObject);
        }
        
        
    }
    private void  destativabotao( ){

    }
}
