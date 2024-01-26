using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawMyLines : MonoBehaviour
{
    private LineRenderer lineRenderer;

    //public Transform origin;
    //public Transform destination;
    public GameObject sphere11;
    public GameObject sphere22;
    public Vector3 Pos1 = Vector3.zero;
    public Vector3 Pos2 = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Pos1 = sphere11.transform.position;
        Pos2 = sphere22.transform.position;
        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.SetPosition(0, sphere11.transform.position);
        lineRenderer.SetPosition(0, Pos1);
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.SetPosition(1, Pos2);
        //origin = sphere1.transform;
        //destination = sphere2.transform;
        //lineRenderer.SetPosition(0, sphere11.transform.position);
        //lineRenderer.SetPosition(1, sphere22.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
 
    }
}
