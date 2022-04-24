using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject OpcionesMenu;

    public string namePlayer;
    public string saveName;

    public Text inputText;
    public Text loadedName;

    void Start()
    {
        OpcionesMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        namePlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = namePlayer;
    }

    public void Opciones()
    {
        OpcionesMenu.SetActive(true);
    }

    public void CerrarOpciones()
    {
        OpcionesMenu.SetActive(false);
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
