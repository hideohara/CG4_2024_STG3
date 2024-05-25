using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMamanagerScript : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        int r = Random.Range(0, 50);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0, 15), Quaternion.identity);
        }
    }

}
