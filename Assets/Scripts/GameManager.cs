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

    void Update()
    {
        namePlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = namePlayer;
    }

    //Activa el panel de opciones
    public void Opciones()
    {
        OpcionesMenu.SetActive(true);
    }

    //Cierra el panel de opciones
    public void CerrarOpciones()
    {
        OpcionesMenu.SetActive(false);
    }

    //Con esto podemos guardar el nombre del jugador
    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
