using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private Quaternion rotationX;
    private float rspeed = .2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                /*float ry = 0;
                float rx = 0;

                if (Mathf.Abs(touch.deltaPosition.x) > 10)
                {
                    rx = touch.deltaPosition.x;
                }*/
                //Debug.Log("delta  " + touch.deltaPosition.x);
                rotationY = Quaternion.Euler(0,
                    -touch.deltaPosition.x * rspeed, 0);

                transform.rotation = rotationY * transform.rotation;

                rotationX = Quaternion.Euler(touch.deltaPosition.y * rspeed/5, 0, 0);

                transform.rotation = rotationX * transform.rotation;

                /*if (Mathf.Abs(touch.deltaPosition.y) > 10)
                {
                    ry = touch.deltaPosition.y;
                }

                rotationX = Quaternion.Euler(ry * rspeed, 0 ,0);

                transform.rotation = rotationX * transform.rotation;*/
            }
        }
    }


}
