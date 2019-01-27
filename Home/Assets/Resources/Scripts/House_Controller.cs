using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_Controller : MonoBehaviour
{
    public bool downKeyDown;
    public bool isCollidedWithCorrectHouse;
    public GameObject player;
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
            Initiate.Fade("Finish", Color.black, 2f);
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Collision Made");
        if (col.gameObject.tag.Contains("player")) {
            Debug.Log("Player Collision" + this.gameObject.tag.ToString());

            if (this.gameObject.CompareTag("playerHouse")) {
                isCollidedWithCorrectHouse = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.tag.Contains("player")) {
            if (this.gameObject.tag == "playerHouse") {
                isCollidedWithCorrectHouse = false;
            }
        }
    }

    public void SetHouseSprite(Sprite houseSprite) {
        SpriteRenderer playerSpriterndr = player.GetComponentInChildren<SpriteRenderer>();
        SpriteRenderer houseSpriterndr = this.GetComponent<SpriteRenderer>();
        if (this.tag.Contains("player")) {
            Debug.Log("Finish House Set to " + houseSpriterndr.sprite.ToString());
            houseSpriterndr.sprite = playerSpriterndr.sprite;
        }
        else {
            houseSpriterndr.sprite = houseSprite;
        }
        if (houseSpriterndr.sprite == playerSpriterndr.sprite) {
            Debug.Log("True" + houseSpriterndr.sprite.ToString());
        }
    }
}
