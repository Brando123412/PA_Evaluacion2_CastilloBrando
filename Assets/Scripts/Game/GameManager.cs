using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntajeText;
    [SerializeField] PlayerMovement scriptPlayer;
    [SerializeField] TMP_Text vida;
    void Start(){
        puntajeText.text = "Puntaje: 0";
        vida.text = "Vida: 3";
    }
    void Update(){
        vida.text = "Vida: "+ scriptPlayer.player_lives;
        puntajeText.text = "Puntaje: " + Mathf.Round(scriptPlayer.player_puntaje);
    }
    
}
