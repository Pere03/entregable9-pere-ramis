using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    public MeshRenderer player;
    public Text level;
    public Text username;
    public Text Trucos;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        ApplyUserOptions();
    }

    public void ApplyUserOptions()
    {
        player.material.color = DataPersistence.sharedInstance.color;
        level.text = DataPersistence.sharedInstance.Nivel.ToString();
        username.text = DataPersistence.sharedInstance.saveName;
        Trucos.text = DataPersistence.sharedInstance.Trucos;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        
    }
}
