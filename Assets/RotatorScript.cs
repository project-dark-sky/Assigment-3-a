using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float speed = 1;
    public bool clockWiseRotation = false;
    private float rotZ;

    // Start is called before the first frame update
    void Start()
    {
        rotZ = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (clockWiseRotation)
        {
            rotZ += Time.deltaTime * speed;
        }
        else
        {
            rotZ -= Time.deltaTime * speed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
