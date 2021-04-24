using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity.Example
{
public class JournalMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject QuestJournal;
    public GameObject CrewJournal;
    public GameObject OptionsJournal;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == true)
            return;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (gameIsPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Journal();
            }
        }
    }

    public void Resume()
    {
        OptionsJournal.SetActive(false);
        CrewJournal.SetActive(false);
        QuestJournal.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Journal()
    {
        OptionsJournal.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void BackGame()
    {
        SceneManager.LoadScene(0);
    }
}
}