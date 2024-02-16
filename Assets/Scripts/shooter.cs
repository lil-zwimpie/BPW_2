using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    public GameObject arrowPrefab;
    float shootSpeed = 200f;
    public Transform spawnpointArrow;
    public Camera playerCamera;
    private ArrowController arrowController;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject newProjectile = Instantiate(arrowPrefab, spawnpointArrow.position, spawnpointArrow.rotation);
            
            newProjectile.transform.rotation = Quaternion.LookRotation(playerCamera.transform.forward);

            Rigidbody projectileRigidbody = newProjectile.GetComponent<Rigidbody>();
            projectileRigidbody.AddForce(newProjectile.transform.forward * shootSpeed, ForceMode.Impulse);
            newProjectile.GetComponent<ArrowController>().SetArrowFired (true);
        }
    } 
}