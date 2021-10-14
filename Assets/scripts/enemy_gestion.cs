using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_gestion : MonoBehaviour
{
    public GameObject enemy;
    public static int LifeRemain;
    // Start is called before the first frame update
    void Start()
    {
        LifeRemain = 4;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (LifeRemain <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
