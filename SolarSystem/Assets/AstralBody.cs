using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstralBody : MonoBehaviour{

    public Vector3 rotatationSpeed;
    public Transform bodyTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }
    public void rotate()
    {
        bodyTransform.Rotate(rotatationSpeed*Time.deltaTime);
    }
}
