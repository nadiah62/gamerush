using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA : MonoBehaviour
{

    public Player w;
    public float Shaking = 0.5f;

    void LateUpdate()
    {
        float mod_shaking = Shaking * w.percentage;
        transform.localPosition = new Vector3(Random.Range(-mod_shaking, mod_shaking), Random.Range(-mod_shaking, mod_shaking), 0);
    }

}

