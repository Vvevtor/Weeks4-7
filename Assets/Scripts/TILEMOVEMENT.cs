using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TILEMOVEMENT : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime ;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
