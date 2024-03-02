using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassWind : MonoBehaviour
{
    public GameObject Grass2;
    public int grassSize = 20;
    void Start()
    {
        for(int z = -grassSize; z <= grassSize; z++)
        {
            for (int x = -grassSize; x <= grassSize; x++)
            {
                Vector3 position = new Vector3(x / 4.0f, 0, z/4.0f);
                GameObject grass = Instantiate(Grass2, position, Quaternion.identity);
                grass.transform.localScale = new Vector3(1, Random.Range(0.8f, 1.2f), 1);
            }
        }
    }


    void Update()
    {
        
    }
}
