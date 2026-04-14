using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public bool isLeftFire = true;
    public float bulletSpd = 7f;

    private Vector3 startPoint;
    private Vector3 controlPoint;
    private Vector3 targetPoint;

    private float time = 0f;
    private float duration = 1.2f;

    private void Start()
    {
        startPoint = transform.position;

        if (isLeftFire)
        {
            controlPoint = startPoint + new Vector3(-2f, 1f, 0f);
            targetPoint = startPoint + new Vector3(0.4f, 6f, 0f);
        }
        else
        {
            controlPoint = startPoint + new Vector3(2f, 1f, 0f);
            targetPoint = startPoint + new Vector3(-0.4f, 6f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 1f)
        {
            transform.Translate(Vector3.up * bulletSpd * Time.deltaTime);
        }
        else
        {
            CurveShot();
        }
    }

    private void CurveShot()
    {
        time += Time.deltaTime * duration;
        Vector3 p1 = Vector3.Lerp(startPoint, controlPoint, time);
        Vector3 p2 = Vector3.Lerp(controlPoint, targetPoint, time);
        Vector3 nextPoint = Vector3.Lerp(p1, p2, time);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, nextPoint - transform.position);
        transform.position = nextPoint;
    }
}
