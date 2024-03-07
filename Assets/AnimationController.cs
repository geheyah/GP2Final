using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
   [SerializeField] private Animator animator;

     private static readonly int Walk = Animator.StringToHash("walking");
     private static readonly int Jump = Animator.StringToHash("jumping");
     
    
       void Start()
    {
        animator = GetComponent<Animator>();  
    }
    
     void Update()
    {
        animator.SetBool ("walking",Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D));
        animator.SetBool ("jumping",Input.GetKey(KeyCode.Space)); 
    }
}
