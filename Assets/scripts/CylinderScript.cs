using UnityEngine;
using Tmr;

public class CylinderScript : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        if (moveX != 0 && !TimerDysplayScript.gameOver)
        {
            transform.Rotate(Vector3.up, moveX * rotationSpeed * Time.deltaTime);
        }
    }
}
