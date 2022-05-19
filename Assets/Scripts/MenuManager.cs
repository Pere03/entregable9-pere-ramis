using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject OpcionesMenu;

    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
          OpcionesMenu.SetActive(false);
        }
        
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Game()
    {
        SceneManager.LoadScene(1);
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
}
