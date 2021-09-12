using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool gameIspaused = false;

    public GameObject PauseMenuUI, car, FPS;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && car.activeInHierarchy == true)
        {
            if (gameIspaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseMenuUI.SetActive(true);
        FPS.SetActive(false);
        Time.timeScale = 0f;
        gameIspaused = true;
    }
    
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        FPS.SetActive(true);
        Time.timeScale = 1f;
        gameIspaused = false;
    }
}
