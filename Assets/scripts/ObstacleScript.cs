using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed = -0.5f;
    private float timer = 0.0f;
    
    void Start()
    {
        int r = Random.Range(-10, 100);
        transform.position = new Vector3(
            transform.position.x, 
            transform.position.y, 
            r
        );
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10) {
            speed -= 0.1f;
            timer = 0;
        }
        transform.position += new Vector3(0, 0, speed);
        if (transform.position.z < -40) {
            int r = Random.Range(60, 300);
            transform.position += new Vector3(0, 0, r);
        }
        transform.Rotate(Vector3.forward, 1.5f * Time.deltaTime);
    }
}
