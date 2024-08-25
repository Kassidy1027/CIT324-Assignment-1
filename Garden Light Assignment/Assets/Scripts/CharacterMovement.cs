using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    // Variable to Hold the Input of Player Movement
    public float h;
    public float v;

    // Variable to Hold Speed
    public int speed;


    /*
     * UNITY DEFAULT METHODS
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Getting the Value from Player Movement
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // Moving the Character without Physics
        transform.Translate(new Vector3 (h, 0, v) * speed * Time.deltaTime);

    }
}
