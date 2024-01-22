using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    int lives = 100;
    [SerializeField] float move_speed = 15;
    [SerializeField] float steer_speed = 300;
    [SerializeField] float slow_speed = 10;
    [SerializeField] float boost_speed = 35;
    bool isAlive = true;
    string player_name = "Jerry";
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0,4.2f);
    }

    // Update is called once per frame
    void Update()
    {
        // if lives==0 
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount * steer_speed);
        transform.Translate(0, moveAmount * move_speed, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            Debug.Log("boost granted :x");
            move_speed = boost_speed;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        move_speed = slow_speed;
        Debug.Log("slow down mate!");
    }
}
