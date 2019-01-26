using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Class is responsible for calling loading all the sprites in the sprites folder
//and dividing the sprites among the houses and player.
//Ensuring there is only 1 match of player-house.
public class Sprite_Controller : MonoBehaviour
{
    public GameObject player;
    private List<GameObject> houses;
    void Start()
    {
        //Get All house Sprites in List.
        List<object> houseSprites = new List<object>(Resources.LoadAll("Sprites/houses", typeof (Sprite)));
        for (int i = 0; i < houseSprites.Count; i++) {
            houseSprites[i] = (Sprite) houseSprites[i];
        }
        //Put All Houses into List
        houses = new List<GameObject>();
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("fillerHouse")) {
            houses.Add(g);
        }
        //Randomly select finish house.
        GameObject finishHouse = houses[Mathf.RoundToInt(Random.Range(0, houses.Count))];
        //Set FinishHouse Tag
        finishHouse.tag = "playerHouse";
        int intSpriteIndex = Mathf.RoundToInt(Random.Range(0, houseSprites.Count));
        //Randomly Select playerHouse Sprite
        Sprite playerSprite = (Sprite) houseSprites[intSpriteIndex];
        //Get Scripts to player and finish house.
        Player playerScript = player.GetComponent<Player>();
        House_Controller finishHouseScript = finishHouse.GetComponent<House_Controller>();
        //Set Player Sprite Randomly and return sprite set.
        playerScript.SetPlayerSprite(playerSprite);
        //Set finish house sprite to sprite returned.
        finishHouseScript.SetHouseSprite(playerSprite);
        //remove finish house from list.
        houses.Remove(finishHouse);
        //remove player sprite from list of usable sprites.
        houseSprites.RemoveAt(intSpriteIndex);
        //Randomly set each house to the new list of available sprites.
        foreach(GameObject house in houses) {
            House_Controller houseScript = house.GetComponent<House_Controller>();
            houseScript.SetHouseSprite((Sprite) houseSprites[Mathf.RoundToInt(Random.Range(0, houseSprites.Count))]);
        }


    }
    void Update()
    {
        
    }
}