using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutLineWall : MonoBehaviour
{
    public GameObject targetObject;
    string targetTag;

    void Start()
    {
        targetTag = targetObject.tag;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            if (targetTag == "Monster")
            {
                ScoreManager.nowScore--;
            }
            Destroy(other.gameObject);
        }
    }
}
