using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Puntaje", menuName = "ScriptableObjects/Puntaje/Puntajescriptableobjects", order = 3)]
public class SavePuntaje : ScriptableObject
{
    public float[] puntajeSave=new float[10];
    public int j=0;
    int x;
    float minValue=float.MinValue;
    public void GuardarPuntaje(float scriptPlayer){
        scriptPlayer=Mathf.Round(scriptPlayer);
        if(j<10){
            puntajeSave[j]=scriptPlayer;
            j++;
            Debug.Log("entro");
        }
        else{
            for (int i = 0; i < puntajeSave.Length; i++)
            {
                if(minValue<puntajeSave[i]){
                    minValue=puntajeSave[i];
                    x=i;
                }
            }
            puntajeSave[x]=scriptPlayer;
        }
    }
}
