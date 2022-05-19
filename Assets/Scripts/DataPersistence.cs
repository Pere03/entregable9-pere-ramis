using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPersistence : MonoBehaviour
{
    public string namePlayer;
    public string saveName;

    public int Nivel;

    public bool SiNo;

    public float Decimal;

    public Text inputText;
    public Text loadedName;

    void Start()
    {
        
    }

    void Update()
    {
        namePlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = namePlayer;
    }

    //Con esto podemos guardar el nombre del jugador
    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
