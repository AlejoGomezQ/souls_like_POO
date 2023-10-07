using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    private int targetIndex = 1;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[targetIndex].position, speed * Time.deltaTime);
        var distance = Vector3.Distance(transform.position, waypoints[targetIndex].position);

        if (distance <= 0.1f)
        {
            if (targetIndex >= waypoints.Count - 1)
            {
                return;
            }
            targetIndex++;
        }
    }
}
