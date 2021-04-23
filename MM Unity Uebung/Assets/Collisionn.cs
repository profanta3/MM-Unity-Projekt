using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionn : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
    }
}
