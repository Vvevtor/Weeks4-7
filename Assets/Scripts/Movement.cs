using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 pos = transform.position;
            pos.x += -speed * Time.deltaTime;

            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 pos = transform.position;
            pos.x += speed * Time.deltaTime;

            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 pos = transform.position;
            pos.y += speed * Time.deltaTime;

            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 pos = transform.position;
            pos.y += -speed * Time.deltaTime;

            transform.position = pos;
        }
    }
}
