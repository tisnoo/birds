using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    public GameObject prefab;


    private Rigidbody rb;

    private int delayTimer;
    private bool delayTimerIsActive;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void SpawnNext()
    {
        GameObject newBox = Instantiate(prefab);
        newBox.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && !delayTimerIsActive)
        {

            for (int i = 0; i < 100; i++)
                SpawnNext();

            delayTimerIsActive = true;
            delayTimer = 60;
        }


        if (delayTimerIsActive && delayTimer > 0)
        {
            delayTimer--;
        }

        if (delayTimer == 0)
        {
            delayTimerIsActive = false;
        }


        if (Input.GetKey(KeyCode.W))
        {

            rb.AddForce(new Vector3(180,0,0), ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.S))
        {

            rb.AddForce(new Vector3(-180, 0, 0), ForceMode.Acceleration);
        }


        if (Input.GetKey(KeyCode.A))
        {

            rb.AddForce(new Vector3(0, 0, 180), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(new Vector3(0, 0, -180), ForceMode.Acceleration);
        }





    }
}
