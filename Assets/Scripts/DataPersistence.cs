using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence sharedInstance;

    public string namePlayer;
    public string saveName;

    public int Nivel;

    public bool SiNo;

    public Color32 color;
    public int colorSeleccionado;

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

        PlayerPrefs.SetInt("NIVEL", Nivel);

        PlayerPrefs.SetString("name", saveName);

        PlayerPrefs.SetInt("ColorSeleccionado", colorSeleccionado);
        PlayerPrefs.SetFloat("Azul", color[0]);
        PlayerPrefs.SetFloat("Verde", color[1]);
        PlayerPrefs.SetFloat("Magenta", color[2]);
    }
}
