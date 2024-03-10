using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2 : MonoBehaviour
{
    public GameObject FirstPersonController;
    public GameObject MainCamera;
    public GameObject Camera;


    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        MainCamera.SetActive(true);
        Camera.SetActive(true);
        FirstPersonController.SetActive(false);
        StartCoroutine(FinishCutscene());
    }

    IEnumerator FinishCutscene()
    {
        yield return new WaitForSeconds(5);
        FirstPersonController.SetActive(true);
        MainCamera.SetActive(false);
        Camera.SetActive(false);
    }

}
