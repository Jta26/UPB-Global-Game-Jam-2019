using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseSpawner : MonoBehaviour
{
    public List<GameObject> houses = new List<GameObject>();
    public List<GameObject> spawnLocations = new List<GameObject>();
    List<GameObject> SpawnChances = new List<GameObject>();

    void Start()
    {
        //roll to select playerHouse
        System.Random rollForPlayer = new System.Random();
        int playerHouse = rollForPlayer.Next(1, 10); 
        Debug.Log(playerHouse);

        //remove the playerhouse from the house list
        houses.RemoveAt(playerHouse);
        Debug.Log(houses);

        //roll to pull a house from the list
        System.Random rollForSpawn = new System.Random();
        int houseChance = rollForSpawn.Next(1, 9);
        Debug.Log(houseChance);

        //place houses at locations (spaced according to asset size)
//        Instantiate(PREFAB, POSITION);

    }
    void Update()
    {
        
    }
}