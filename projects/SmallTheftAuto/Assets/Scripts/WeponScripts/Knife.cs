using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    private Animator _animator;
    public GameObject knife;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        GetComponentInChildren<Knife>().gameObject.SetActive(true);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Ha-ha!");
            Slash();
        }
        //Add on click for it to perform slash animation
        //Add on slashhit - > deal damage, or whatever
    }
    
    public void Slash() 
    {
        _animator.SetTrigger("Attack");
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("I hit!" + col.name);
        if (col.tag == "Enemy")
        {
            col.GetComponent<IEnemy>().TakeDamage(10);
            Debug.Log("I hit enemy!");
        }
    }
}
