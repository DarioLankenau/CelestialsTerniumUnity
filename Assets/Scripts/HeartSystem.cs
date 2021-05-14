using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public static int life = 3;


    // Update is called once per frame
    void Update()
    {
        if(life < 1)
        {
            Destroy(hearts[0].gameObject);
            gameOver();
        } else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        } else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    public void gameOver()
    {
        SceneManager.LoadScene("MenuFinal");
    }
}
