using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour
{
    private GameObject Tracker;
    private Material Grass;

    void Start()
    {
        Grass = GetComponent<Renderer>().material;
        Tracker = GameObject.Find("Tracker");
    }

 
    void Update()
    {
        Vector3 TrackerPos = Tracker.GetComponent<Transform>().position;

        Grass.SetVector("_Tracker", TrackerPos);
    }
}
