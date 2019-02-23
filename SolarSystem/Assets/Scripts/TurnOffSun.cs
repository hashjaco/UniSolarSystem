using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffSun : MonoBehaviour

    
{
    public GameObject sun;
    private Light light;
    private Behaviour halo;
    // Start is called before the first frame update
    void Start()
    {
        light = sun.GetComponent<Light>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)){

            light.enabled = !light.enabled;
            sun.GetComponent<Behaviour>().enabled = !sun.GetComponent<Behaviour>().enabled;
        }
    }
}
