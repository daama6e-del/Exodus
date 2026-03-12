using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void Restart()
    {
        Thread.Sleep(500);
        SceneManager.LoadScene(0);
    }
    public void Fork()
    {
        Thread.Sleep(0);
        SceneManager.LoadScene(1);
    }

    public void Franklin()
    {
        Thread.Sleep(500);
        SceneManager.LoadScene(2);
    }
    public void Thackery()
    {
        Thread.Sleep(500);
        SceneManager.LoadScene(3);
    }
}
