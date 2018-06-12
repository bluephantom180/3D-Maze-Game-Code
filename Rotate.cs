using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public int Rotatespeed;
	
	
	void Update () {
        transform.Rotate(0, Rotatespeed, 0, Space.World);
	}
}
