using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnScript01 : MonoBehaviour {
//
    public int numberToSpawn;
    public GameObject SpawnLocation01;
//    public GameObject HouseSprite1;
//    public GameObject HouseSprite2;
    public List<GameObject> houses;
    Vector3 pos1;
    int SpawnChance01;
    int SpawnChance02;
//
    void Start()
    {
        //set position to spawn, based on gameObject with script 
        Vector3 pos01 = SpawnLocation01.transform.position;
        //playerHouse random 
        System.Random rollPlayer = new System.Random();
        int playerHouseInt = rollPlayer.Next(1, 10); //roll a number, tied to a house (1 to 9 for a total of 9 houses)
        Debug.Log(playerHouseInt);
        //housesArray - remove playerhouse by ID
        //house1
        System.Random roll = new System.Random();
        int SpawnChance01 = roll.Next(1, 9); //roll a number, tied to a house
        Debug.Log(SpawnChance01); 
    }
    void Update()
    {
        if ( SpawnChance01 = 1 ) //chance spawn 1
        {
            Instantiate(HouseSprite1, pos01, transform.position);
        }
}
}