using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject bulletFireLeftObject;
    public GameObject bulletFireRightObject;

    bool leftFire = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire1 Button: LeftCtrl
        bool isFire = Input.GetButtonDown("Fire1");

        if (isFire)
        {
            if (leftFire)
            {
                GameObject bullet = Instantiate(bulletObject);
                bullet.transform.position = bulletFireLeftObject.transform.position;
                leftFire = false;
            }
            else
            {
                GameObject bullet = Instantiate(bulletObject);
                bullet.transform.position = bulletFireRightObject.transform.position;
                leftFire = true;
            }
        }
    }
}
