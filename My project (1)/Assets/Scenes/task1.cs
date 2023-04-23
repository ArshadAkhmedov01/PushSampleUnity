using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class task1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(true);
        Debug.Log("On trigger enter isledi");
    }

    private void OnTriggerStay(Collider other)
    {
        other?.gameObject.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
        Debug.Log("obcektden kecdi");
    }


    private void OnCollisionEnter(Collision collision) //enter daxil olmaq demekdir
    {
        Debug.Log("On COllision enter isledi");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay collision isdedi");
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.SetActive(false);
        Debug.Log("obcektden kecdi");
    }

}
