using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpWhenTalking : MonoBehaviour {

    private float normal = 8f;
    private float zoomed = 4.5f;

    private float smooth = 5f;

    private bool zoomBool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (zoomBool)
        {
            Debug.Log("zoooom");
            //Camera.main.orthographicSize = 4.5f;
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomed, Time.deltaTime * smooth);
        }
        else
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normal, Time.deltaTime * smooth);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            zoomBool = true;
            Debug.Log("hello");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "NPC")
        {
            zoomBool = false;
        }
    }
}
