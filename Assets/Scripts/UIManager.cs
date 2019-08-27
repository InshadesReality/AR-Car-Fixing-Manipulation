using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private bool c1 = true;
    private bool c2 = true;
    private bool c3 = true;
    private bool c4 = true;

    public GameObject ColorPanel;
    public GameObject SettingsPanel;
    public GameObject ModelPanel;
    public GameObject Lights;

    public Button lightBtn;
    public Sprite offButton;
    public Sprite onButton;



    public void PanelColor()
    {
        if (c1 == true)
        {
            ColorPanel.gameObject.SetActive(true);
            c1 = false;
        }
        else
        {
            ColorPanel.gameObject.SetActive(false);
            c1 = true;
        }

    }
    public void PanelSettings()
    {
        if (c2 == true)
        {
            SettingsPanel.gameObject.SetActive(true);
            c2 = false;
        }
        else
        {
            SettingsPanel.gameObject.SetActive(false);
            c2 = true;
        }
    }
    public void LightButton()
    {
        if(c3 == true)
        {
            Lights.gameObject.SetActive(true);
            lightBtn.image.sprite = onButton;
            c3 = false;
        }
        else
        {
            Lights.gameObject.SetActive(false);
            lightBtn.image.sprite = offButton;
            c3 = true;
        }

    }
    public void SelectModel()
    {
        if (c4 == true)
        {
            ModelPanel.gameObject.SetActive(true);
            c4 = false;
        }
        else
        {
            ModelPanel.gameObject.SetActive(false);
            c4 = true;
        }
    }


    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Car1()
    {
        SceneManager.LoadScene(1);
    }
    public void Car2()
    {
        SceneManager.LoadScene(2);
    }
    public void Checkout()
    {
        SceneManager.LoadScene(3);
    }
}
