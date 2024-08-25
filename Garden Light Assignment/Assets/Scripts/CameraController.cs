using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * REFERENCED FROM PREVIOUS SCRIPTS
 */


public class CameraController : MonoBehaviour
{
    // Referencing the Player's GameObject
    public GameObject character;

    // Placeholder for the Distance Between Camera and Player
    //private Vector3 cameraOffset;

    // Start Method, Called Before the First Frame Update
    void Start()
    {
        // Calculating the Offset Between Camera's Position and Player's Position
        //cameraOffset = transform.position - character.transform.position;
    }

    // LateUpdate Called Once per Frame Once all Updates Functions are Completed
    void LateUpdate()
    {
        // Helping Maintain the Same Offset Between Player and Camera Through the Game
        transform.position = character.transform.position;
    }
}