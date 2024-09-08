using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;




    private void Start()
    {
        Invoke("KillMyself", 3.0f);
    }
    void Update()
    {
        transform.Translate(Vector3.forward *  moveSpeed * Time.deltaTime);
    }

    private void KillMyself()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
