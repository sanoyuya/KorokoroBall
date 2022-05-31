using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    GameObject[] coins;
    GameObject[] coinWall;

    private void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, false);//1920×1080のウィンドウモード
        coins = GameObject.FindGameObjectsWithTag("Coin");
        coinCount = 0;
    }

    void Update()
    {
        GameObject coinwall = GameObject.Find("CoinWall");
        if (DestroyAllCoins())
        {
            Destroy(coinwall);
        }
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
    }

    private bool DestroyAllCoins()
    {
        foreach (GameObject c in coins)
        {
            if (c != null)
            {
                return false;
            }
        }
        return true;
    }
}
