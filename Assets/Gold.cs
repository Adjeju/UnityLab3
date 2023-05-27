using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public GameObject menuObject;
    private Menu Menu;

    public void Start()
    {
        Menu = menuObject.GetComponent<Menu>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           Menu.AddGold();

            print("you take 1 gold");
            this.gameObject.SetActive(false);
        }
    }
}
