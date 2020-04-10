using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootshoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        }
    }
}
