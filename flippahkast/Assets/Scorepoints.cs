using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorepoints : MonoBehaviour {
    public int score;
    public Text tekst;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        score = score + 10;
        tekst.GetComponent<Text>().text = score.ToString();
        
    }
}
