using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript01 : MonoBehaviour {

    public List<GameObject> houses = new List<GameObject>();
    public List<GameObject> spawnLocations = new List<GameObject>();
    List<GameObject> SpawnChances = new List<GameObject>();

    void Start()
    {
        //Index house locations:
        System.Random testHouseRoll = new System.Random();
        int testIntRand = testHouseRoll.Next(1, 10);
        Debug.Log(houses[testIntRand]);

        //set position to spawn, based on gameObject with script 
        //Vector3 pos01 = SpawnLocation01.transform.position;

        //playerHouse random selection
        System.Random rollPlayer = new System.Random();
        int playerHouseInt = rollPlayer.Next(1, 10); //roll a number, tied to a house (1 to 9 for a total of 9 houses)
        Debug.Log(playerHouseInt);

        //housesArray - remove playerhouse by ID

        //HouseSpawn @ Location 
        System.Random roll = new System.Random();
        int SpawnChance01 = roll.Next(1, 9); //roll a number, tied to a house
        //GameObject SpawnHouse = houses[SpawnChance01];
        //Instantiate(SpawnHouse, SpawnLocation01.transform);    
    }
    void Update()
    {
        
    }
}