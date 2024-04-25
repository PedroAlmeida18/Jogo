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
    public float tempo = 100f;
    public Text texto ;
    private bool paraTempo;
    void awake(){

    }
    void Start()
    {
        Poder.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       ContaTempo();
      
        
    }
    public void OnButtonClick(){
        if(!Poder.activeSelf){
            
            Poder.SetActive(true);
        
        } 
        if(Poder.activeSelf){
            Destroy(botao.gameObject);
        }
        
        
    }
    private void  destativaPoder( ){
        if(tempo == 0){
            Poder.SetActive(false);
        }

    }
    private void ContaTempo(){
        if(paraTempo==true){
         tempo = tempo - Time.deltaTime;
        texto.text = "Tempo é : " + tempo.ToString("0");
        if(tempo<=0){
            paraTempo = false;
            destativaPoder();
        }
        }
        

    }
}
