using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private bool isArrowFired = false;

    void OnCollisionEnter(Collision collision)
    {
        if (isArrowFired)
        {
            Rigidbody projectileRigidbody = GetComponent<Rigidbody>();
            if (projectileRigidbody != null)
            {
                Debug.Log(collision.gameObject.name,collision.gameObject);
                Destroy(projectileRigidbody);
                transform.SetParent(collision.transform);
            }
            isArrowFired = false; 
        }
    }

    public void SetArrowFired(bool value)
    {
        isArrowFired = value;
    }
}