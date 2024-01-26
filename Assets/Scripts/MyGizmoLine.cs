using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmoLine : MonoBehaviour
{
    public Vector3 Pos1 = Vector3.zero;
    public Vector3 Pos2 = Vector3.zero;

    //public GameObject sphere1;
    //public GameObject sphere2;
 
    
    // Start is called before the first frame update
    void Start()
    {
        //Pos1 = sphere1.transform.position;
        //Pos2 = sphere2.transform.position;
        Pos1.Set(0.0f, 0.0f, 0.0f);
        Pos2.Set(1.0f, 1.0f, 1.0f);
    }

    private void Update()
    {

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Pos1, Pos2);
        Gizmos.DrawSphere(Pos1, 0.1f);
        Gizmos.DrawSphere(Pos2, 0.1f);
    }
}
