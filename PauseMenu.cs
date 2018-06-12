using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class PauseMenu : MonoBehaviour
    {

        public Transform canvas;
        public Transform player;
        
        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Restart();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Quit();
            }
        }
        public void Pause()
        {

            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                player.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                player.GetComponent<FirstPersonController>().enabled = true;
            }
        }

        public void Restart()
        {
            if(Application.loadedLevelName=="Level 1")
            {
                Application.LoadLevel("Level 1");
            }

            else if(Application.loadedLevelName == "Level 2")
            {
                Application.LoadLevel("Level 2");
            }

            else if (Application.loadedLevelName == "Level 3")
            {
                Application.LoadLevel("Level 3");
            }

            else if (Application.loadedLevelName == "Level 4")
            {
                Application.LoadLevel("Level 4");
            }

            else if (Application.loadedLevelName == "Bonus Level 2")
            {
                Application.LoadLevel("Bonus Level 2");
            }
        }

        public void Quit()
        {
            Application.LoadLevel("menu");
        }
    }
}
