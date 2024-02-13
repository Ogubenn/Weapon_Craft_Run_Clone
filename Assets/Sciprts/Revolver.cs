using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Revolver : MonoBehaviour
{
    public GameObject revolver;

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Bullet"))
        {
            Debug.Log("Döndü");
            //anim.SetTrigger("RevolverAnim");
            //Destroy(hit);
            //Quaternion currentRotation = transform.rotation;
            //Quaternion newRotation = Quaternion.Euler(currentRotation.eulerAngles + new Vector3(0f, 0f, 1f));
            //transform.rotation = newRotation;
            //transform.DORotate(new Vector3(0f, 0f, 60f), 5f);
            revolver.transform.DORotate(new Vector3(0f, 0f, 60f), 100f);
        }
    }
    


}//class
