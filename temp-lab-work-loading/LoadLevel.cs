// https://medium.com/fusedvr/implementing-vr-scene-transitions-c27861a9ac77

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

    public int currentLevel = 0;
    public string[] levelNames= new string[2] { "HelloWorldVR", "example" };

    static LoadLevel s = null;

	// Use this for initialization
	void Start () {
		if (s == null)
        {
            s = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            currentLevel = (currentLevel + 1) % 2;
            SteamVR_LoadLevel.Begin(levelNames[currentLevel]);
        }
    }
}
