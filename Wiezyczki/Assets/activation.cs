using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activation : MonoBehaviour
{
    public float timer = 0.0f;
    public bool limit;
    // Start is called before the first frame update
    void Start()
    {
        timer = 6.0f;
        limit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.tower_count < 100 && limit ==true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                gameObject.GetComponent<TowerScript>().enabled = true;
                gameObject.GetComponent<activation>().enabled = false;
            }
        }

        else if (UI.tower_count >= 100)
        {
            gameObject.GetComponent<TowerScript>().enabled = true;
            gameObject.GetComponent<activation>().enabled = false;
            limit = false;
        }
    }
}
