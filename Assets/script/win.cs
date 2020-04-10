using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject floorGameObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(floorGameObject))
        {
            Debug.Log("You Win");
        }
    }
 }
