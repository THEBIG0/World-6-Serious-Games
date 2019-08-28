using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("script pointAndClick running");
    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }
    
    void OnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("i clicked something");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit ))
            {
                if(hit.transform != null)
                {
                    Debug.Log(hit.transform.gameObject);
                }
            }
        }
    }
}
