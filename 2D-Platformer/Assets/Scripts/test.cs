using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text MyText;
    public int score { get; private set; }

    // Use this for initialization
    void Start()
    {

        MyText.text = "";

    }


    // Update is called once per frame
    void Update()
    {

        MyText.text = "$" + score;

    }

    void OnTriggerEnter(Collider coll)
    {

        if (coll.CompareTag("Pickable"))
        {
            score = score + 1;
        }

        if (coll.CompareTag("Pickable"))
        {
            Destroy(coll.gameObject);
        }

    }
}
