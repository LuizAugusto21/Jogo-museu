using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interacao : MonoBehaviour
{

    public Text mensagemInteracao;
    private GameObject jogador;
    public Canvas dialogo;

    bool inside = false;
   
    void Start()
    {
        mensagemInteracao.enabled=false;
        dialogo.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if( inside && Input.GetKeyDown("f")){
            Debug.Log("FFF");

            mensagemInteracao.enabled=false;
            dialogo.enabled=true;
        }
    }

    void OnTriggerEnter2D(){
        inside = true;
        mensagemInteracao.enabled=true;
    }

    void OnTriggerExit2D(){
        inside = false;
        mensagemInteracao.enabled=false;
        dialogo.enabled=false;
    }

}
