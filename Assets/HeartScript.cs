using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public float maxTarget = 5.0f;
    public float minTarget = 1.0f;
    public float speed = .5f;
    private Vector3 state;
    private int dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        state = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        state += new Vector3(dir, dir, dir) * speed * Time.deltaTime;
        transform.localScale = state;

        Debug.Log(dir + " " + state + " " + transform.localScale);
        if (transform.localScale.x >= maxTarget)
        {
            dir = -1;
        }
        else if (transform.localScale.x <= minTarget)
        {
            dir = 1;
        }

    }
}
