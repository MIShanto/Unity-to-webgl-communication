using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;


public class test : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR

    [DllImport("__Internal")]
    private static extern void BlockHotkeys();

#endif

    public TextMeshProUGUI text;
    
    private void Start() 
    {
    
        #if UNITY_WEBGL && !UNITY_EDITOR
            BlockHotkeys();
        #endif
    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.A))
        {
            text.text = "ctrl + a";
        }

        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.S))
        {
            text.text = "ctrl + s";
        }
    }
}
