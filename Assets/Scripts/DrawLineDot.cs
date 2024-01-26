using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DrawLineDot : MonoBehaviour
{
    //private LineRenderer lineRenderer;


    //public Transform origin;
    //public Transform destination;
    public GameObject sphere11;
    public GameObject sphere22;
    public Vector3 Pos1 = Vector3.zero;
    public Vector3 Pos2 = Vector3.zero;
    public Vector3 Pos3 = Vector3.zero;
    public Vector3 delta = Vector3.zero;
    public Text scalarvalue;
    public float homegrown; 

    // Start is called before the first frame update
    void Start()
    {

        Pos1 = sphere11.transform.position;
        Pos2 = sphere22.transform.position;
        delta = new Vector3(1.0f, 2.0f, 0.1f);
        Pos3 = Pos1 + delta;
        float myscalarproduct = Vector3.Dot(Pos2, Pos3);
        //Debug.Log(myscalarproduct + "is my product");
        
        homegrown = Pos2.x * Pos3.x + Pos2.y * Pos3.y + Pos2.z * Pos3.z;

        scalarvalue.text = myscalarproduct + " is my unity dot product and " + homegrown + " is my dot product" ;
        //lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.startWidth = 0.05f;
        //lineRenderer.endWidth = 0.05f;
        //lineRenderer.SetPosition(0, Pos1);
        //lineRenderer.SetPosition(1, Pos2);


    }

    // Update is called once per frame
    void Update()
    {
        
 
    }
}
