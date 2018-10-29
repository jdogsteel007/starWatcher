using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseEnter()
    {
        print(gameObject.name);
        gameObject.transform.localScale += new Vector3(.45f, .45f, 0);
    }

    private void OnMouseExit()
    {
        gameObject.transform.localScale -= new Vector3(.45f, .45f, 0);
    }
}
