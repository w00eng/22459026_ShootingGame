using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject straightBulletObject;
    public GameObject curveBulletObject;
    public GameObject bulletFireLeftObject;
    public GameObject bulletFireRightObject;

    private bool isStraightFire;
    private bool isCurveFire;
    private bool leftFire = true;

    void Update()
    {
        if (!PlayManager.isGameOver)
        {
            isStraightFire = Input.GetButtonDown("Fire1");
            isCurveFire = Input.GetButtonDown("Fire2");
        }

        if (isStraightFire)
        {
            if (leftFire)
            {
                GameObject bullet = Instantiate(straightBulletObject);
                bullet.transform.position = bulletFireLeftObject.transform.position;
                leftFire = false;
            }
            else
            {
                GameObject bullet = Instantiate(straightBulletObject);
                bullet.transform.position = bulletFireRightObject.transform.position;
                leftFire = true;
            }
        }

        if (isCurveFire)
        {
            if (leftFire)
            {
                GameObject bullet = Instantiate(curveBulletObject);
                bullet.transform.position = bulletFireLeftObject.transform.position;
                leftFire = false;
            }
            else
            {
                GameObject bullet = Instantiate(curveBulletObject);
                bullet.transform.position = bulletFireRightObject.transform.position;
                bullet.GetComponent<CurveBulletController>().isLeftFire = false;
                leftFire = true;
            }
        }
    }
}
