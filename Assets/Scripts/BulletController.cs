using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpd = 3.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpd * Time.deltaTime);
    }
}
