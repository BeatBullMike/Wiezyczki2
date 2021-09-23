using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    float timer = 0.5f;
    public int ammo = 12;
 

    //bullet
    public GameObject bulletPrefab;
    public Transform firePoint;

 

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        if (ammo >= 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                timer += 0.5f;
                transform.Rotate(0.0f, Random.Range(15, 45), 0.0f);
                Shoot();

            }
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        }

        if (UI.tower_count >= 100)
        {
            ammo = 12;
        }

    }

    void Shoot ()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
            bullet.SetActive(true);
            ammo -= 1;
        }
    }
}
