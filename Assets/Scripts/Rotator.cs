using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public GameObject pickUp;
    public float translationSpeed = 0.25f;
    public bool debugshow;

    private bool goingUp;
    private float initPosition;

    void Start()
    {
        goingUp = true;
        initPosition = pickUp.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        Levitate();
    }

    void Levitate()
    {
        if ((pickUp.transform.position.y < initPosition + 0.25f) && goingUp)
        {
            transform.Translate(0, translationSpeed * Time.deltaTime, 0, Space.World);
        }
        else if ((pickUp.transform.position.y > initPosition) && !goingUp)
        {
            transform.Translate(0, -translationSpeed * Time.deltaTime, 0, Space.World);
        }
        else
        {
            goingUp = !goingUp;
        }
    }

}
