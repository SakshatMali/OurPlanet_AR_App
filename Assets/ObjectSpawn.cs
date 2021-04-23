using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    public Canvas canvas;
    private PlacementIndicatorScript placementIndicator;
    public bool earth = true;

    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicatorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (earth)
            {
                GameObject obj = Instantiate(objectToSpawn,
                    placementIndicator.transform.position, placementIndicator.transform.rotation);

                GameObject obj2 = Instantiate(objectToSpawn2,
                    placementIndicator.transform.position, placementIndicator.transform.rotation);

                //canvas.gameObject.SetActive(true);

                earth = false;
            }
        }
    }
}
