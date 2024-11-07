using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcmovement : MonoBehaviour
{
    public float speed;
    public List<Transform>  waypoints;
    private Transform targetWaypoint;
    private int targetIndex = 0;
    // Start is called before the first frame update
    void Start()
    { 
        //Debug.Log("hallo");
        targetWaypoint = waypoints[targetIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
        FollowWaypoint(targetWaypoint);
        CheckArrival();
    }
    private void CheckArrival()
    {
        float distance = Vector3.Distance(transform.position, targetWaypoint.position);
        if (distance < 0.5f)
        {
            targetWaypoint = GetNextTargetWaypoint();
        }
    }
    private void FollowWaypoint(Transform waypoint)
    {
        //zorgen dat het object de waypoint volgt
        Vector3 direction = waypoint.position - transform.position;
        Vector3 newRotation = Vector3.RotateTowards(transform.forward, direction, Mathf.PI*2/36, Mathf.PI * 2);
        transform.rotation = Quaternion.LookRotation(newRotation);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private Transform GetNextTargetWaypoint()
    {
        if (targetIndex < waypoints.Count - 1)
        {
            
                targetIndex++; 
        }
        else
        {
            this.enabled = false;
        }
        return waypoints[targetIndex];
    }
}
