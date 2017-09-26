using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSwordActive : MonoBehaviour {

    public Transform sword;

    void Start()
    {
        sword.gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Chest" && Input.GetKeyDown(KeyCode.E))
        {
            sword.gameObject.SetActive(true);
        }
    }
}
