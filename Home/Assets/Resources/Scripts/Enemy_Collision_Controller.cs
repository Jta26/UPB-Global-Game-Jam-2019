using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject == player) {
            Initiate.Fade("Exit", Color.black, 2f);
        }
    }
}
