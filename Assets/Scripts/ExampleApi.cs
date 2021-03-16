using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleApi : MonoBehaviour
{
    private void Awake()
    {
        StaticBatchingUtility.Combine(transform.gameObject);
    }
}
