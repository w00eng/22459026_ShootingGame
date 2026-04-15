using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster: MonoBehaviour
{
    public float monsterSpd = 3f;
    private Vector3 direct = Vector3.down;
    public int monsterHP = 1;

    public GameObject prefabsExplosion;
    public GameObject prefabsHit;

    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();

        monsterHP = Random.Range(1, 7);

        int ranNum = Random.Range(0, 10);
        if (ranNum < 3)
        {
            GameObject target = GameObject.FindGameObjectWithTag("Player");
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
            monsterHP -= 1;

            GameObject hitObj = Instantiate(prefabsHit);
            hitObj.transform.position = collision.contacts[0].point;

            Destroy(collision.gameObject);

            if (monsterHP <= 0)
            {
                ScoreManager.nowScore++;

                if (ScoreManager.nowScore > ScoreManager.bestScore)
                {
                    ScoreManager.bestScore = ScoreManager.nowScore;
                    scoreManager.bestScoreUI.text = "BEST SCORE: " + ScoreManager.bestScore;
                    PlayerPrefs.SetInt("BestScore", ScoreManager.bestScore);
                }

                GameObject explosionObj = Instantiate(prefabsExplosion);
                explosionObj.transform.position = transform.position;

                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            PlayManager.isGameOver = true;
        }
    }
}
