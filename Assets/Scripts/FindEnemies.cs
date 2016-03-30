using UnityEngine;
using System.Collections;

public class FindEnemies : MonoBehaviour
{
    private GameObject[] enemies;

    void Start()
    {
        GoFindEm();
    }

    void Update()
    {
    }

    void GoFindEm() {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
}
