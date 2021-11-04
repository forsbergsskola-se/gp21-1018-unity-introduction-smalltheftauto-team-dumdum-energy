using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPointAnimation : MonoBehaviour
{
    private Animator _qpAnimator;
    
    void Start()
    {
        
    }


    private void OncollisionEnter(Collision collision)
    {
        _qpAnimator = gameObject.GetComponent<Animator>();
        _qpAnimator.SetTrigger("QuestPointAnimation");
    }
}
