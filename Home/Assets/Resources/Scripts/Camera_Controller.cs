using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    private float originY;

    // Start is called before the first frame update
    void Start()
    {
        offset.x = transform.position.x - player.transform.position.x;
        offset.y = transform.position.y - player.transform.position.y;
        originY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        Transform thistrans = this.GetComponent<Transform>();
        Vector3 thispos = thistrans.position;
        thispos.z = -10f;
        thispos.x = player.transform.position.x < -180 ? -180 : (player.transform.position.x > 180 ? 180 : player.transform.position.x + offset.x);
        if(player.transform.position.y > thispos.y || thispos.y > originY) thispos.y = player.transform.position.y;
        if(thispos.y < originY) thispos.y = originY;
        transform.position = thispos;
    }
}
