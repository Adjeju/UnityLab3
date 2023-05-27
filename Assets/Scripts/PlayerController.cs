using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator _animator;
    public float speed = 7f;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        GetInput();
        _animator.SetBool("isRunning", isRunning);
    }

    public bool isRunning = false;

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
            isRunning = true;
            return;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
            isRunning = true;
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
            isRunning = true;
            return;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
            isRunning = true;
            return;
        }

        isRunning = false;

    }
}
