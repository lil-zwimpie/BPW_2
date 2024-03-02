using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }

     

}