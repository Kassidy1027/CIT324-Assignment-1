using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenLightController : MonoBehaviour
{

    // Variable to Hold the Character
    public GameObject character;

    // Variable to Hold the Particle Effect 
    public GameObject particleEffect;

    // Variable to Hold Activation Distance 
    private float activationDistance = 25f;


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
        // Checking the Distance from the Player
        if (Vector3.Distance(character.transform.position, transform.position) < activationDistance)
        {
            // Setting the Particle Effect to Active
            particleEffect.SetActive(true);

        } else
        {
            // Setting the Particle Effect to Inactive
            particleEffect.SetActive(false);
        }
    }
}
