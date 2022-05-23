using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence sharedInstance;

    public string truco;
    public string namePlayer;
    public string saveName;
    public int nivel;
    public string Trucos;
    public Color32 color;
    public int color_Seleccionado;
    public bool sino;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            Destroy(this);
        }
    }

    public void Data()
    {
        PlayerPrefs.SetInt("Nivel", nivel);

        PlayerPrefs.SetString("NOMBRE", saveName);

        PlayerPrefs.SetInt("Color_Seleccionado", color_Seleccionado);
        PlayerPrefs.SetFloat("Azul", color[0]);
        PlayerPrefs.SetFloat("Verde", color[1]);
        PlayerPrefs.SetFloat("Magenta", color[2]);

        PlayerPrefs.SetInt("Trucazo", sino ? 1 : 0);

        PlayerPrefs.SetString("TRUCO", truco);
    }
}
