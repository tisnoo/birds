using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public float turnSpeed = 4.0f;
    public Transform player;

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(player.position.x, player.position.y, player.position.z + 7.0f);
    }

    void LateUpdate()
    {
        //transform.position = player.position + offset;

        transform.LookAt(player.position);

        transform.RotateAround(player.position, Vector3.right, Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime);
    }
}
