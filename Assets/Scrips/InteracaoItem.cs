using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracaoItem : MonoBehaviour
{

    public Text mensagemInteracao;
    private GameObject jogador;
    public GameObject item;
   
    void Start()
    {
        mensagemInteracao.enabled=false;
        item.SetActive(true);
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
            item.SetActive(false);

        }
    }

    void OnTriggerExit2D(){
        mensagemInteracao.enabled=false;
    }

}
