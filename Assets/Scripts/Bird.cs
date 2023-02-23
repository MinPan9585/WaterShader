using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Transform[] waypoints;
    public int index = 1;
    public float speed;
    public Transform target;

    private void Start()
    {
        target = waypoints[index];
    }

    void Update()
    {
        transform.Translate(Vector3.Normalize(target.position - transform.position) * speed * Time.deltaTime, Space.World);
        transform.LookAt(target);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            if(index == 1)
            {
                target = waypoints[0];
                index = 0;
            }
            else
            {
                target = waypoints[1];
                index = 1;
            }
            
        }
    }
}
