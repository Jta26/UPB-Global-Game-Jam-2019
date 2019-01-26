using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Button_Controller : MonoBehaviour
{
    
    public Button btnExit;
    public Button btnSceneChange;
    public string sceneName;    
    // Start is called before the first frame update
    void Start()
    {
        if(btnExit) {
            btnExit.onClick.AddListener(() => {
                        Debug.Log("test");
                        QuitGame();
            });
        }
        if (btnSceneChange) {
            btnSceneChange.onClick.AddListener(() => {
                        Debug.Log("Scene Change Button Clicked");
                        SceneChange(sceneName);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SceneChange(string strScene) 
    {
        Debug.Log("Changing to " + strScene);
        SceneManager.LoadScene(strScene);
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Exiting Game");
    }

}
