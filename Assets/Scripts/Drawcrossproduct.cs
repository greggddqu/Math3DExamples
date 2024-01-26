using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drawcrossproduct : MonoBehaviour
{
    private LineRenderer lineRenderer;

    public GameObject sphere11;
    public GameObject sphere22;
    public Vector3 Pos1 = Vector3.zero;
    public Vector3 Pos2 = Vector3.zero;
    public Vector3 Pos3 = Vector3.zero;
    public Vector3 delta = Vector3.zero;
    public Vector3 homegrown = Vector3.zero;
    public Vector3 mycrossproduct = Vector3.zero;
    public Text mytextvalue;

    // Start is called before the first frame update
    void Start()
    {

        Pos1 = sphere11.transform.position;
        Pos2 = sphere22.transform.position;
        delta = new Vector3(2.0f, 2.0f, 1f);
        Pos3 = Pos1 + delta;
        mycrossproduct = Vector3.Cross(Pos2, Pos3);
        Debug.Log(mycrossproduct + "is my product");
        float xval = Pos2.y * Pos3.z - Pos2.z * Pos3.y;
        float yval = Pos2.x * Pos3.z - Pos2.z * Pos3.x;
        float zval = Pos2.x * Pos3.y - Pos2.y * Pos3.x;
        homegrown = new Vector3(xval, -yval, zval);

        mytextvalue.text = mycrossproduct + " is my unity cross product and " + homegrown + " is my cross product";
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.SetPosition(0, Pos1);
        lineRenderer.SetPosition(1, homegrown);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
