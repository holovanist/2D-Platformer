using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneTransfer : MonoBehaviour
{
    GameObject SpawnPos;

    public string levelToLoad = "Logan 2";


    // Start is called before the first frame update
    void Start()
    {
        SpawnPos = GameObject.FindGameObjectWithTag("Scene Start Point 1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(levelToLoad);
            gameObject.transform.position = SpawnPos.transform.position;
        }
    }
    void Awake()
    {
        if (tag == "Player")
        {
            DontDestroyOnLoad(this.gameObject);
        }
        SpawnPos = GameObject.FindGameObjectWithTag("Scene Start Point 1");
        gameObject.transform.position = SpawnPos.transform.position;
    }
}
