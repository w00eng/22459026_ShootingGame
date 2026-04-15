using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject prefabsMonster;

    float nowTime = 0f;
    float createTime = 1f;
    float spawnX = 0f;
    public float minTime = 1f;
    public float maxTime = 5f;

    public float monsterSpd = 3f;

    private void Awake()
    {
        nowTime = 0f;
        monsterSpd = 3f;
        minTime = 1f;
        maxTime = 5f;
    }

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
        spawnX = Random.Range(-2f, 2f);
    }

    void Update()
    {
        nowTime += Time.deltaTime;
        monsterSpd = (monsterSpd <= 20f) ? (monsterSpd + Time.deltaTime / 10) : 20f;

        if (nowTime > createTime)
        {
            GameObject monster = Instantiate(prefabsMonster);
            monster.transform.position = transform.position + new Vector3(spawnX, 0f, 0f);
            monster.GetComponent<Monster>().monsterSpd = monsterSpd;

            minTime = (minTime >= 0.2f) ? (minTime - Time.deltaTime * 10) : 0.2f;
            maxTime = (maxTime >= 1f) ? (maxTime - Time.deltaTime * 50) : 1f;

            createTime = Random.Range(minTime, maxTime);
            spawnX = Random.Range(-2f, 2f);

            nowTime = 0f;
        }
    }
}
