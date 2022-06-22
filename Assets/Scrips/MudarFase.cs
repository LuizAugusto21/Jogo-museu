using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarFase : MonoBehaviour
{

    public GameObject area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(){

        switch (area.name)
        {
            case "EntradaCaverna":
                SceneManager.LoadScene("Caverna");
                break;
            
            case "EntradaPrimeiroAndar":
                SceneManager.LoadScene("Caverna");
                break;
            
            case "EntradaSegundoAndar":
                SceneManager.LoadScene("Caverna");
                break;

            case "EntradaSalaAnatomia":
                SceneManager.LoadScene("Caverna");
                break;

            case "EntradaSalaDinossauros":
                SceneManager.LoadScene("Caverna");
                break;

            case "EntradaSalaIndigenas":
                SceneManager.LoadScene("Caverna");
                break;

            case "EntradaSalaRN":
                SceneManager.LoadScene("Caverna");
                break;


            default:
                Debug.Log("Coloque o nome correto");
                break;
        }
        if(area.name == "EntradaCaverna"){
            SceneManager.LoadScene("Caverna");
        }
    }
}
