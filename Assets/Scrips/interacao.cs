using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interacao : MonoBehaviour
{

    public Text mensagemInteracao;
    private GameObject jogador;
    public Canvas dialogo;
   
    void Start()
    {
        mensagemInteracao.enabled=false;
        dialogo.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(){
        mensagemInteracao.enabled=true;
    }

    void OnTriggerStay2D(){

        if(Input.GetKeyDown("f")){
            mensagemInteracao.enabled=false;
            dialogo.enabled=true;

        }
    }

    void OnTriggerExit2D(){
        mensagemInteracao.enabled=false;
        dialogo.enabled=false;
    }

}
