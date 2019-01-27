using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;  
    // Start is called before the first frame update
    void Start()
    {
        offset.x = transform.position.x - player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Transform thistrans = this.GetComponent<Transform>();
        Vector3 thispos = thistrans.position;
        thispos.z = -10f;
        thispos.x = player.transform.position.x + offset.x;
        transform.position = thispos;
    }
}
