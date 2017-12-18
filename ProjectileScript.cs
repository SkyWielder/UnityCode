//SkyWielder [12]
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProjectileScript : MonoBehaviour
{


    public Vector2 location = new Vector2(2, .75f);
    public GameObject magicSphere;
    public float speed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject magicPrefab = (Instantiate(magicSphere, GetComponent<PlayerScript>().MyRigidbody.position + location, Quaternion.identity)) as GameObject;
            Debug.Log("Projectile is found");
            Rigidbody2D magicPrefabRigid = magicPrefab.GetComponent<Rigidbody2D>();

            magicPrefabRigid.AddForce(Vector2.right * speed);

            Debug.Log("Force is added");
            Destroy(magicPrefab, .76f);
        }
    }

    public void FireMagic()
    {
        //GameObject Clone;
       

    }







}
