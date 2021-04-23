using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    public Transform earth;
    // Start is called before the first frame update
    void Start()
    {
        //earth = earth.GetComponent<OptionSelect>().earth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scaleup()
    {
        earth.transform.localScale += new Vector3(.1f, .1f, .1f);
        Debug.Log(earth.transform.localScale);
    }

    public void Scaledown()
    {
        earth.transform.localScale += new Vector3(-.1f, -.1f, -.1f);
        Debug.Log(earth.transform.localScale);
    }
}
