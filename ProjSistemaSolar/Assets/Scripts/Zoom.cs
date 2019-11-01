using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

    //This is Main Camera in the Scene
    Camera m_MainCamera;
    bool toggle = true;


    void Start()
    {
        //This gets the Main Camera from the Scene
        m_MainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))

            if (toggle == true)
            {
                toggle = false;
               m_MainCamera.fieldOfView = 10;
               Debug.Log("toggle era p it p 19" + toggle);

            }
            else
            {
                m_MainCamera.fieldOfView = 39;
                toggle = true;
                Debug.Log("toggle era p ir p 39" + toggle);
            }
    
    }
}