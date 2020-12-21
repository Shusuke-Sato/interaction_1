using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public static int stageNo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartStage1()
    {
        stageNo = 1;
        SceneManager.LoadScene("Tutorial");
    }
    public void StartStage2()
    {
        stageNo = 2;
        SceneManager.LoadScene("Tutorial");
    }
    public void StartStage3()
    {
        stageNo = 3;
        SceneManager.LoadScene("Tutorial");
    }
    public void StartStage4()
    {
        stageNo = 4;
        SceneManager.LoadScene("Tutorial");
    }
    public void StartStage5()
    {
        stageNo = 5;
        SceneManager.LoadScene("Tutorial");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Title");
    }
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

}
