using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_Controller : MonoBehaviour
{
    private bool downKeyDown;
    private bool isCollidedWithCorrectHouse;
    // Start is called before the first frame update
    void Start()
    {
        downKeyDown = false;
        isCollidedWithCorrectHouse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {

            downKeyDown = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)) {

            downKeyDown = false;
        }
        if (isCollidedWithCorrectHouse && downKeyDown) {
            Debug.Log("Condition to finish level met.");
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player") {
            if (this.gameObject.tag == "playerHouse") {
                isCollidedWithCorrectHouse = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            if (this.gameObject.tag == "playerHouse") {
                isCollidedWithCorrectHouse = false;
            }
        }
    }
}
