using UnityEngine;
using System.Collections;

public class Detection : MonoBehaviour
{
    public LayerMask detectionLayer;
    private const float DetectionFrequency = 0.5f;
    private float nextCheck;
    private RaycastHit hitInfo;
    private const float Range = 5f;
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
        bool hitFound = Physics.Raycast(origin, direction, out hitInfo, Range, detectionLayer);

        if (hitFound)
        {
            // TODO handle hit
            Debug.Log(hitInfo.transform.name + "is an item");
        }
    }
}
