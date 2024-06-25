using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    [Header("Platform Object")]
    public GameObject platform;
    float pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {

            SpawnPlatforms();
        }
    }

    // Spawn platforms function
    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }

    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active
        gameOverCanvas.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
