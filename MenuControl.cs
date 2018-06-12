using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

	public void PlayGame()
    {
        Application.LoadLevel("Level 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
