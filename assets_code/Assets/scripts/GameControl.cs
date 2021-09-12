using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameControl : MonoBehaviour
{
    public GameObject player, maincamera, uielements, home, virus_spawner, carrot_spawner,settings ,scene, esc;

    public AudioMixer audiomixer;

    public Slider slider;

    public float value;

    public GameObject credits, controls;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        player.SetActive(false);
        maincamera.SetActive(false);
        uielements.SetActive(false);
        virus_spawner.SetActive(false);
        carrot_spawner.SetActive(false);
        home.SetActive(true);
        scene.SetActive(true);
        settings.SetActive(false);
        esc.SetActive(false);
    }

    void Update()
    {
        bool results = audiomixer.GetFloat("volume", out value);

        if (results)
        {
            slider.value = value;
        }

    }

    public void start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        virus_spawner.SetActive(true);
        carrot_spawner.SetActive(true);
        uielements.SetActive(true);
        player.SetActive(true);
        maincamera.SetActive(true);
        scene.SetActive(false);
        home.SetActive(false);
        settings.SetActive(false);
        controls.SetActive(false);
        credits.SetActive(false);
    }

    public void restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void GOsettings()
    {
        home.SetActive(false);
        settings.SetActive(true);
    }

    public void goBack()
    {
        home.SetActive(true);
        settings.SetActive(false);
        controls.SetActive(false);
        credits.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }

    
    public void OpenControls()
    {
        home.SetActive(false);
        controls.SetActive(true);
    }

    public void OpenCredits()
    {
        home.SetActive(false);
        credits.SetActive(true);
    }


    //settings

    public void SetVolumn(float volumn)
    {
        audiomixer.SetFloat("volume",volumn);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}
