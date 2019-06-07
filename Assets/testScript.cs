using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class testScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MLHands.Start();
        MLInput.Start();
        Debug.Log("Test successful");
    }

    private void OnDestroy()
    {
        MLHands.Stop();
        MLInput.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
