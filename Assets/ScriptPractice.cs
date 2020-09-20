using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] cnt = { 1, 2, 3, 4, 5 };
        for(int i = 0; i <= 4; i++)
        {
            Debug.Log(cnt[i]);
        }
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(cnt[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
