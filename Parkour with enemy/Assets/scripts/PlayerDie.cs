using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{

    public Vector3 PlayerStartPos;
    public GameObject player;
    
    public CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        //Getting position and the CharcterController
        PlayerStartPos = player.transform.position;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //restart the level
        if (Input.GetKey(KeyCode.R)) {
            Debug.Log("R Being Clicked");
            //there was a problem with the CharacterController and teleporting so we had to disable it
            controller.enabled = false;
            transform.position = PlayerStartPos;
            controller.enabled = true;
        }

       
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player dead");
        //same here
        controller.enabled = false;
        transform.position = PlayerStartPos;
        controller.enabled = true;
    }

}
