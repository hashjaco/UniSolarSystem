using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : AstralBody
{
    // Start is called before the first frame update
    public Transform center;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = RotatePointAroundPivot(transform.position,
                            transform.parent.position,
                            Quaternion.Euler(0, speed* Time.deltaTime, 0));
        Rotate();
    }


    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }
}
