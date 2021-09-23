using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static int tower_count = 0;
    //text
    public Text t1;
    static public bool limit;

    void Start()
    {
        t1 = GameObject.Find("Text").GetComponent<Text>();
        limit = true;
    }

    private void Update()
    {
        if (tower_count >= 100)
        {
            limit = false;
        }

        tower_count = GameObject.FindGameObjectsWithTag("wieza").Length;
            t1.text = "Wiezyczki:" + tower_count.ToString();
    }
}
