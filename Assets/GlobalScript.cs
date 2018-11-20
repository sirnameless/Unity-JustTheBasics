using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour {

    public int players = 1;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);	
	}
}
