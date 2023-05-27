using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    public Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z)){
            _animator.SetTrigger("death");
        }
        if(Input.GetKey("left shift")){
            _animator.SetTrigger("shift");
        }if(Input.GetKey("space")){
            _animator.SetTrigger("jump");
        }if(Input.GetMouseButtonDown(0)){
            _animator.SetTrigger("hit");
        }
    }


}
