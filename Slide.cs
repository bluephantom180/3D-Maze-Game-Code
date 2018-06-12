using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Slide : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
      transform.Translate(0, Time.deltaTime, 0);
    }
 }

