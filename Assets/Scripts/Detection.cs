using UnityEngine;
using System.Collections;

public class Detection : MonoBehaviour
{
    private const float DetectionFrequency = 0.5f;
    private float nextCheck;
    private RaycastHit hitInfo;

    void Start()
    {
        DetectItems();
    }

    void Update()
    {
        if (Time.time > nextCheck) {
            nextCheck = Time.time + DetectionFrequency;
            DetectItems();
        }
    }

    void DetectItems()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        bool hitFound = Physics.Raycast(origin, direction, out hitInfo);

        if (hitFound) {
            // TODO handle hit
        }
    }
}
