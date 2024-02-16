using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    public GameObject arrowPrefab;

    [SerializeField]
    float shootSpeed = 200f;

    public Transform spawnpointArrow;
    public Camera playerCamera;
    private ArrowController arrowController;

    [SerializeField]
    private Cloth cloth;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newProjectile = Instantiate(arrowPrefab, spawnpointArrow.position, spawnpointArrow.rotation);

            newProjectile.transform.rotation = Quaternion.LookRotation(playerCamera.transform.forward);

            Rigidbody projectileRigidbody = newProjectile.GetComponent<Rigidbody>();
            projectileRigidbody.AddForce(newProjectile.transform.forward * shootSpeed, ForceMode.Impulse);
            newProjectile.GetComponent<ArrowController>().SetArrowFired(true);

            CapsuleCollider projectileCollider = projectileRigidbody.GetComponent<CapsuleCollider>();

            List<CapsuleCollider> colliders = cloth.capsuleColliders.ToList();
            colliders.Add(projectileCollider);

            cloth.capsuleColliders = new CapsuleCollider[colliders.Count];
            cloth.capsuleColliders = colliders.ToArray();

            Debug.Log(projectileCollider, projectileCollider);
        }
    }
}