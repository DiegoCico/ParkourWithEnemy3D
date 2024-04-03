using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //aray
    public GameObject[] waypoints;
    //index of the array
    int currentWaypointIndex = 0;

    public float speedE;


    // Start is called before the first frame update
    void Start()
    {
        speedE = Random.Range(1f, 10f); //start with a random speed
    }

    // Update is called once per frame
    void Update()
    {
        //saying if we touch the waypoints this happens
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f) {
            currentWaypointIndex++;
            //^^ saying if we reach the waypoint we go to the next waypoint

            speedE = Random.Range(1f, 10f); // setting a new random speed every waypoint

            // saying that if we reach the last waypoint we restart the waypoints  
            if (currentWaypointIndex >= waypoints.Length) {
                currentWaypointIndex = 0;
            }
        }

        // the first component is the platform position, the second is where it wants to go(we made it into a array because there are 2 waypoints)
        // and the 3rd is the speed of it
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speedE * Time.deltaTime);
    }
}
