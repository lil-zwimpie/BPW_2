using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject FirstPersonController;
    public GameObject MainCamera;


    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        MainCamera.SetActive(true);
        FirstPersonController.SetActive(false);
        StartCoroutine(FinishCutscene());
    }

    IEnumerator FinishCutscene()
    {
        yield return new WaitForSeconds(5);
        FirstPersonController.SetActive(true);
        MainCamera.SetActive(false);
    }
}
