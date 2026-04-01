using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster: MonoBehaviour
{
    public float monsterSpd = 1f;
    Vector3 direct = Vector3.down;

    public GameObject prefabsExplosion;

    // Start is called before the first frame update
    void Start()
    {
        int ranNum = Random.Range(0, 10);
        if (ranNum < 3)
        {
            GameObject target = GameObject.Find("Character");
            direct = target.transform.position - transform.position;
            direct.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (direct * monsterSpd * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameObject explosionObj = Instantiate(prefabsExplosion, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
