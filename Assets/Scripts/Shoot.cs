using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    private float fireRate = 0.3f;
    private float nextFire;

    void Start()
    {
    }

    void Update() {
        CheckInput();
    }

    void CheckInput() {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (Time.time > nextFire) {
            // TODO fire
            Debug.Log("shoot");
            nextFire = fireRate + Time.time;
        }
    }
}
