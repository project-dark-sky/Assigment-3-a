using UnityEngine;

public class SpotMoverScript : MonoBehaviour
{

    public float range = 20;
    public Vector2 startPositon = new Vector2(0, 0);
    public Vector3 speed = new Vector3(0, 0, 0);
    private int direction = 1;
    private float force;

    // Start is called before the first frame update
    void Start()
    {
        startPositon.x = transform.position.x;
        startPositon.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Mathf.Floor(Mathf.Abs(transform.position.x - (startPositon.x + range * direction)));
        force = constrain(dist / range, 0, 1);
        transform.position += speed * direction * force * Time.deltaTime;

        if (force == 0)
        {
            direction *= -1;
        }
    }



    float constrain(float val, float min, float max)
    {
        if (val > max)
        {
            return max;
        }
        if (val < min)
        {
            return min;
        }
        return val;
    }
}
