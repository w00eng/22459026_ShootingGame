using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPClick : MonoBehaviour
{
    public GameObject _HTPScreen;

    public void OnClickHTP()
    {
        _HTPScreen.SetActive(true);
    }

    public void OnClickCloseHTP()
    {
        _HTPScreen.SetActive(false);
    }
}
