using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class NPC : MonoBehaviour
{
    public Transform objectToLookAt;
    public float headWeight;
    public float bodyWeight;
    private Animator animator;

    public Vector3 headOffset;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (!GameManager.Instance.head)
            return;
        animator.SetLookAtPosition(objectToLookAt.position +headOffset);
        animator.SetLookAtWeight(1, bodyWeight, headWeight);
    }
}