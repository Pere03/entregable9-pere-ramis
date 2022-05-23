    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public GameObject OpcionesMenu;
    public GameObject[] colors;
    private int level;
    private int minLevel = 1;
    private int maxLevel = 3;
    private int colorSeleccionado;
    public TMP_InputField loadedName;
    public Text loadedLevel;
    


    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
          OpcionesMenu.SetActive(false);
        }

        level = int.Parse(loadedLevel.text);
        LoadUserOptions();
    }

    private void Update()
    {
        ColorSelection();
    }

    //Con esto guardamos los datos que hemos cambiado en opciones, para poder usarlo en otras escenas
    public void SaveUserOptions()
    {
        DataPersistence.sharedInstance.color_Seleccionado = colorSeleccionado;

        DataPersistence.sharedInstance.color = colors[colorSeleccionado].GetComponent<Image>().color;

        DataPersistence.sharedInstance.nivel = level;

        DataPersistence.sharedInstance.saveName = loadedName.text;

        DataPersistence.sharedInstance.Data();
    }

    public void LoadUserOptions()
    {
        if (PlayerPrefs.HasKey("Color_Seleccionado"))
        {
            colorSeleccionado = PlayerPrefs.GetInt("Color_Seleccionado");

            level = PlayerPrefs.GetInt("Nivel");
            UpdateLevel();

            loadedName.text = PlayerPrefs.GetString("NOMBRE");
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //Con esto podemos seleccionar mediante las flechas del teclado, que color queremos para nuestro jugador
    private void ColorSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            colorSeleccionado++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            colorSeleccionado--;
        }

        colorSeleccionado %= 3;
        ChangeColorSelection();
    }

    private void ChangeColorSelection()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].transform.GetChild(0).gameObject.SetActive(i == colorSeleccionado);
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Con esto podemos elegir que nivel queremos, pulsando un mas y un menos.
    public void Plus()
    {
        level++;
        level = Mathf.Clamp(level, minLevel, maxLevel);
        UpdateLevel();
    }

    public void Minus()
    {
        level--;
        level = Mathf.Clamp(level, minLevel, maxLevel);
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        loadedLevel.text = level.ToString();
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
