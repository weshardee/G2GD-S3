using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    void Start()
    {
    }

    void Update() {
        CheckInput();
    }

    void CheckInput() {
        if (Input.GetKey(KeyCode.Mouse0)) {
            // TODO fire
        }
    }
}
