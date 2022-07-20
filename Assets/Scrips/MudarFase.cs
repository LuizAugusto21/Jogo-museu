using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarFase : MonoBehaviour
{
    public Text mensagemInteracao;
    public GameObject area;
    public bool gotLanterna;
    public InteracaoItem lanterna;
    // Start is called before the first frame update
    void Start()
    {
        mensagemInteracao.enabled=false;
        gotLanterna = false;
    }

    // Update is called once per frame
    void Update()
    {
        gotLanterna = lanterna.gotLanterna;
    }

    void OnTriggerEnter2D(){
        if(gotLanterna == false){
            mensagemInteracao.enabled=true;
            return;
        }
        switch (area.name)
        {
            case "EntradaCaverna":
                SceneManager.LoadScene("Caverna");
                break;
            
            case "EntradaPrimeiroAndar":
                SceneManager.LoadScene("");
                break;
            
            case "EntradaSegundoAndar":
                SceneManager.LoadScene("");
                break;

            case "EntradaSalaAnatomia":
                SceneManager.LoadScene("");
                break;

            case "EntradaSalaDinossauros":
                SceneManager.LoadScene("");
                break;

            case "EntradaSalaIndigenas":
                SceneManager.LoadScene("");
                break;

            case "EntradaSalaRN":
                SceneManager.LoadScene("");
                break;


            default:
                Debug.Log("Coloque o nome correto");
                break;
            }
    }
}
