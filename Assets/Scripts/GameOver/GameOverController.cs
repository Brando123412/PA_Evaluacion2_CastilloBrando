using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverController : MonoBehaviour
{
    [SerializeField] SavePuntaje sosavePuntaje;
    [SerializeField] TMP_Text[] puntajes = new TMP_Text[10];
    public Button btnPlay;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => ReturnMenu());
        for (int i = 0; i < puntajes.Length; i++)
        {
            puntajes[i].text ="Puntaje "+i+" : "+sosavePuntaje.puntajeSave[i];
        }
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
