using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnScript01 : MonoBehaviour {
    public int numOfHouses;
    GameObject housePrefab;
    void Start()
    {
        //Get the House Prefab from Directory.
        housePrefab = (GameObject) Resources.Load("prefabs/Static/House");

        List<float> houseLocs = new List<float>();
        //Populate Filler Houses list.
        for (int i = 0; i <= numOfHouses; i++) {
            houseLocs.Add(GetRandomMultipleOfFive(houseLocs));
        }
        //Generate the Finish House from 0 in house locations

        GameObject finishHouse = GenerateFinishHouse(houseLocs[0]);
        // //Remove it from the list.
        // houseLocs.Remove(0);
        //Get it's position
        Transform fTrans = finishHouse.GetComponent<Transform>();
        List<GameObject> houses = new List<GameObject>();
        foreach(float num in houseLocs) {
            Debug.Log(num.ToString());
            houses.Add(GenerateHouse(num)); 
        }
        Vector2 finishHousePos = new Vector2(fTrans.position.x, fTrans.position.y);
    }
    void Update()
    {
        
    }
    GameObject GenerateFinishHouse(float x) {
        Vector2 pos = new Vector2(15 + x, -3);
        GameObject house = Instantiate(housePrefab, pos, Quaternion.identity);
        house.tag = "playerHouse";
        return house;
    }
    GameObject GenerateHouse(float x) {
        Vector2 pos = new Vector2(x, -3);
        GameObject house = Instantiate(housePrefab, pos, Quaternion.identity);
        return house;
    }
    float GetRandomMultipleOfFive(List<float> currentNums) {
        float GeneratedNumber = Random.Range(5, numOfHouses * 3) * 5;
        if (currentNums.Contains(GeneratedNumber)) {
            return GetRandomMultipleOfFive(currentNums);
        }
        else {
            return GeneratedNumber;
        }
        
    }
}