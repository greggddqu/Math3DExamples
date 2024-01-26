using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drawnorm : MonoBehaviour
{
    private LineRenderer lineRenderer;

    public GameObject sphere11;
    public GameObject sphere22;
    public Vector3 Pos1 = Vector3.zero;
    public Vector3 Pos2 = Vector3.zero;
    public Vector3 Pos3 = Vector3.zero;
    public Vector3 delta = Vector3.zero;
    public Vector3 homegrown = Vector3.zero;
    public Vector3 mynorm = Vector3.zero;
    public Text mytextvalue;

    // Start is called before the first frame update
    void Start()
    {

        Pos1 = sphere11.transform.position;
        Pos2 = sphere22.transform.position;
        delta = new Vector3(-2.0f, 2.0f, 2.0f);
        Pos3 = Pos1 + delta;
        mynorm = Pos3.normalized;
        Debug.Log(mynorm + "is my product");
        float xval = Pos3.x*Pos3.x;
        float yval = Pos3.y*Pos3.y;
        float zval = Pos3.z*Pos3.z;
        float normscalar = Mathf.Sqrt(xval + yval + zval);
        homegrown = Pos3/normscalar;

        mytextvalue.text = mynorm + " is my unity normal and " + homegrown + " is my normal";
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        //lineRenderer.SetColors
        lineRenderer.SetPosition(0, Pos1);
        lineRenderer.SetPosition(1, homegrown);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
