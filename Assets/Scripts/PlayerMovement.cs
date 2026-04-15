using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float spd = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, v, 0);

        Vector3 newPosition = transform.position + direction * spd * Time.deltaTime;

        newPosition.x = (newPosition.x >= 2.5f) ? 2.5f :
                        (newPosition.x <= -2.5f) ? -2.5f : newPosition.x;
        newPosition.y = (newPosition.y >= -2f) ? -2f :
                        (newPosition.y <= -5f) ? -5f : newPosition.y;

        transform.position = newPosition;
    }
}
