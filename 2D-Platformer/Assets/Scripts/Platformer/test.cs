using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    [SerializeField]
    string leveltoload = "Logan 2";
    [SerializeField]
    int cointest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cointest += 1;
            Debug.Log (cointest);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(leveltoload);
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
