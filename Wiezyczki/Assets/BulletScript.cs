using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float lifetime;
    public float maxlifetime = 0f;
    public GameObject tower_to_Spawn;

    private void Start()
    {

    }

    private void OnEnable()
    {
        lifetime = 0f;
        maxlifetime = Random.Range(1, 4);
    }

        private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        lifetime += Time.deltaTime;
        if (lifetime > maxlifetime)
        {
            if (UI.limit == true)
            {
                Spawn();
                gameObject.SetActive(false);
            }
            else if (UI.limit == false)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void Spawn()
    {

            Instantiate(tower_to_Spawn, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wieza")
        {
            Destroy(col.gameObject);
            gameObject.SetActive(false);
        }
    }
}
