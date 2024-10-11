using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Animator Anim;
    public Transform parent;
    private void Start()
    {
        parent = transform.parent;
        Anim = parent.GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetTrigger("Open");
            other.GetComponent<Move>().canTell = true;
        }
            
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¶³¾îÁü");
            Anim.SetTrigger("Close");
        }
            
    }
}
