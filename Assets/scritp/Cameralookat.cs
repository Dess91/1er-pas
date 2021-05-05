using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways] 
public class Cameralookat : MonoBehaviour
{
    public bool CamerAtCamera = false;
    public Transform target;

    void Update()
    {
       if (target !=null){
           transform.LookAt(target);
       } 
       if (CamerAtCamera == true) {
           if (Camera.main !=null){
           transform.LookAt(Camera.current.transform);
           }
       }
    }
}

