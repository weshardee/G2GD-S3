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
        if (Time.time > nextFire)
        {
            // add firing delay
            nextFire = fireRate + Time.time;

            // cast the ray
            Vector3 origin = transform.position;
            Vector3 direction = transform.forward;
            RaycastHit hitInfo;
            bool hit = Physics.Raycast(origin, direction, out hitInfo);

            // exclude non-enemy hits
            hit = hit && hitInfo.transform.CompareTag("Enemy");

            // draw the debug ray
            Color rayColor = hit ? Color.green : Color.red;
            Debug.DrawRay(origin, direction, Color.green, 3f);

            if (hit) {
                Debug.Log(hitInfo.transform.name);

                // TODO destroy the object
            }
        }
    }
}
