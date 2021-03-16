using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed;
    public bool rotateChilds;

    void Update()
    {
        if (rotateChilds)
            RotateChilds();
        else
            RotateParent();
    }

    void RotateChilds()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
            transform.GetChild(i).Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
        }
    }

    void RotateParent()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
    }
}
