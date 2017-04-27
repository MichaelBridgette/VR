using UnityEngine;
using System.Collections;

public class MoveSquare : MonoBehaviour {

    float speed = -0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(0, 0, speed);
	}


    void OnCollisionEnter(Collision coll)
    {
        speed=-speed;
    }
}
