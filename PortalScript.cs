//Skywielder [12]
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D aCollision)
    {
        if (aCollision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("Level2");
            Debug.Log("Welcome to level 2");
        }
    }
}

