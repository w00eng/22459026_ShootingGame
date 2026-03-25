using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutLineWall : MonoBehaviour
{
    public GameObject targetObject;
    string targetTag;

    // Start is called before the first frame update
    void Start()
    {
        targetTag = targetObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            Destroy(other.gameObject);
        }
    }
}
