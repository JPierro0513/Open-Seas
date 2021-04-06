using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject JournalMenuUI;
    public GameObject crosshairUI;
    public GameObject Questsimage;
    public GameObject crewmatesimage;
    public GameObject blankimage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (gameIsPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    public void Resume()
    {
        JournalMenuUI.SetActive(false);
        crosshairUI.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.L)) Cursor.lockState = CursorLockMode.None;
        crosshairUI.SetActive(false);
        JournalMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    void Quests()
    {
        blankimage.SetActive(false);
        Questsimage.SetActive(true);
        crewmatesimage.SetActive(false);
    }

    void crewmates()
    {
        blankimage.SetActive(false);
        Questsimage.SetActive(false);
        crewmatesimage.SetActive(true);
    }

    void options()
    {
        blankimage.SetActive(true);
        Questsimage.SetActive(false);
        crewmatesimage.SetActive(false);
    }
}
