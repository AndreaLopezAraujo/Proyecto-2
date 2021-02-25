using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planos : MonoBehaviour
{
    Color detalle1 = new Color(0.4f, 0.8f, 0.3f);
    // Start is called before the first frame update
    void Start()
    {
        planoFondo();
    }
    void planoFondo()
    {
        Vector3 vc1;
        Vector3 vc3;
        Color c1;
        vc1=new Vector3(2f, -0.47f, -4.26f);
        vc3=new Vector3(1f ,1f,1f);
        c1=detalle1;
        GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.position = vc1;
        plane.transform.localScale = vc3;
        plane.transform.Rotate (0.0f, 0f, 0f, Space.Self );
        var planeRenderer0 = plane.GetComponent<Renderer>();
        planeRenderer0.material.SetColor("_Color", c1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
