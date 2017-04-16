using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject prefMeat;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(1))
        {
            CreateMeat();
        }
		
	}

    void CreateMeat(){
        Instantiate(prefMeat);
    }
}
