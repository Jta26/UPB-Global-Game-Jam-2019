using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Controller : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait() {
        yield return new WaitForSeconds(5);
        Initiate.Fade(sceneName, Color.black, 0.5f);
    }
}
