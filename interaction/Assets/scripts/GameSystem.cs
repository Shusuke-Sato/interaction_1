using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("dungeon_ver1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Title");
    }
<<<<<<< HEAD
    public void NextGame()
    {
        stageNo = stageNo + 1;
        SceneManager.LoadScene("Tutorial");
    }
    public void DoneTutorial()
    {
        Debug.Log(stageNo);
        switch (stageNo)
        {
            case 1:
                SceneManager.LoadScene("Stage1");
                break;
            case 2:
                SceneManager.LoadScene("Stage2");
                break;
            case 3:
                SceneManager.LoadScene("Stage3");
                break;
            case 4:
                SceneManager.LoadScene("Stage4");
                break;
            case 5:
                SceneManager.LoadScene("Stage5");
                break;
            default:
                SceneManager.LoadScene("Title");
                break;
        }
    }
=======

>>>>>>> teraoka
}
