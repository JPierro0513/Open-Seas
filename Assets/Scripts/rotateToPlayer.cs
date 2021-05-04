using System;
using UnityEngine;

public class rotateToPlayer : MonoBehaviour
{
    public GameObject target;

    void Update() 
    {
        Vector3 v3 = target.transform.position - transform.position;
        v3.y = 0.0f;
        transform.rotation = Quaternion.LookRotation(-v3);
    }
}
