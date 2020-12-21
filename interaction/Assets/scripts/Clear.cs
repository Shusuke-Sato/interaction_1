using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public GameSystem gamesystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        int stageNo;
        stageNo = GameSystem.stageNo;
        if(collision.gameObject.tag == "Player")
        {
            if(stageNo == 5)
            {
                SceneManager.LoadScene("Complete");
            }
            else
            {
                SceneManager.LoadScene("GameClear");
            }
        }
    }
}
