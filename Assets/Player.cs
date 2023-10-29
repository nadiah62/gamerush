using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float drag = 6;

    public Rigidbody R;
    private Vector3 rot;
    public float percentage;
    

    private void Start() // Fixed the method name to "Start"
    {
        R = GetComponent<Rigidbody>();
        rot = transform.eulerAngles;
    }

    private void Update()
    {
         

        rot.x += 20 * Input.GetAxis("Velocity") * Time.deltaTime;
        rot.x = Mathf.Clamp(rot.x, 0, 45);

        rot.y += 20 * Input.GetAxis("Horizontal") * Time.deltaTime;

        rot.z += -5 * Input.GetAxis("Horizontal") * Time.deltaTime;
        rot.z = Mathf.Clamp(rot.z, -5, 5);

        transform.rotation = Quaternion.Euler(rot);

        percentage = rot.x / 45;

        float mod_drag = (percentage * -2) + 6;
        float speed_drag = percentage*(13.8f - 12.5f) + 12.5f;
        R.drag = drag;
        Vector3 localV = transform.InverseTransformDirection(R.velocity);
        localV.z = speed;
        R.velocity = transform.TransformDirection(localV);
    }
}
