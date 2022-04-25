using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public GameObject[] colors;
    private int colorSelected;
    public GameObject Borde1;
    public GameObject Borde2;
    public GameObject Borde3;
    public GameObject Cubo;

    void Update()
    {
        ColorSelection();
    }

    //Con esto conseguimos mediante moviendo las flechas del teclado, podemos seleccionar un color de entre 3 en este caso
    private void ColorSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            colorSelected++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            colorSelected--;
        }

        colorSelected %= 3;
        ChangeColorSelection();
    }

    private void ChangeColorSelection()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].transform.GetChild(0).gameObject.SetActive(i == colorSelected);
        }
    }

    //Aqui hacemos que dependiendo de que color este seleccionado, le cambiamos el color al jugador
    public void OnClick()
    {
        if (Borde1.activeSelf)
        {
            Cubo.GetComponent<Image>().color = new Color32(0, 20, 255, 255);
        }

        if (Borde2.activeSelf)
        {
            Cubo.GetComponent<Image>().color = new Color32(0, 255, 2, 255);
        }

        if (Borde3.activeSelf)
        {
            Cubo.GetComponent<Image>().color = new Color32(250, 0, 255, 255);
        }
    }
}
