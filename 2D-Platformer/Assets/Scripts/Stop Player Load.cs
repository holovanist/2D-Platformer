using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StopPlayerLoad : MonoBehaviour
{
    GameObject menu;
    // Start is called before the first frame update
    private void OnLevelWasLoaded(int level)
    {
        menu = GameObject.FindGameObjectWithTag("menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (menu != null)
        {

        }
    }
}
