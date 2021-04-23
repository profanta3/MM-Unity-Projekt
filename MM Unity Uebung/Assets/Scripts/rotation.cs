using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0.0f, 0.0f, 5.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1);
    }
}
