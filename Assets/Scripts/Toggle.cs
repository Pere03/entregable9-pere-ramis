using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toggle : MonoBehaviour
{
    public Text loadedTruco;
    public Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        //if (toggle.isOn)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveUserOptions()
    {
        DataPersistence.sharedInstance.Trucos = loadedTruco.text;
    }

    public void LoadUserOptions()
    {
        loadedTruco.text = PlayerPrefs.GetString("TRUCOS");
    }

    public void CheatsOn(bool on)
    {
        if (on)
        {
            loadedTruco.text = "Activado";
        }
        if(!on)
        {
            loadedTruco.text = "Desactivado";
        }
    }
}
