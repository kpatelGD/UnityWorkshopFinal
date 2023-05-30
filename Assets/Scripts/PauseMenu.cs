using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    public GameObject PauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Stop();
        }
    }

    void Stop()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
    
    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }


}
