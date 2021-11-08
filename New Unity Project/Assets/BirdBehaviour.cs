using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 2.0f;  // Units per second

    private float randomSpeed = 100;
    public Rigidbody targetBlock;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            Vector3 random = new Vector3(Random.Range(0- randomSpeed, randomSpeed), Random.Range(0 - randomSpeed, randomSpeed), Random.Range(0 - randomSpeed, randomSpeed));

        float addForce = Random.Range(0, 3);

        Vector3 dir = targetBlock.position - rb.position + random;


        if (addForce == 2)
        {

            transform.LookAt(targetBlock.position);
            rb.AddForce(dir, ForceMode.Acceleration);
        }
       

        //Vector3 dir = (targetBlock.position - transform.position).normalized * 2.0f;

        //rb.velocity = dir;

        //rb.position = transform.position + targetBlock.position * Time.deltaTime * Vector3.Distance(transform.position, targetBlock.position);


        //if (Input.GetMouseButton(0))
        // {
        //    var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    targetPos.z = transform.position.z;
        //    transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        //}
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        //transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        //rb.MovePosition(transform.position + (new Vector3(1, 0, 0) * Time.deltaTime));
    }
}
