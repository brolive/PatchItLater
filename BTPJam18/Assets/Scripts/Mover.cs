using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Vector2 direction;
    public Transform target;
    public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        target.transform.Translate(direction * speed * Time.deltaTime);
        RaycastHit hit;
        if(Physics.Raycast(target.position, direction, out hit, 2))
        {
            Debug.Log("HIT");
            if(hit.transform.name.Contains("GroundTile") ||
                hit.transform.name.Contains("Fan"))
            {
                Debug.Log("REVERSE");
                direction = -direction;
            }
            
        }
	}
}
