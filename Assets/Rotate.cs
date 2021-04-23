using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform earth;
    public float rspeed = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        earth.Rotate(new Vector3(0, rspeed * Time.deltaTime, 0));
    }
}
