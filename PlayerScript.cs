// James Cravotta
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float Speed = 15;
    public float JumpForce = 200;
    public Rigidbody2D MyRigidbody;
    private Vector3 origin;
    public int myHealth = 100;
    public Text healthText;

    // set jumpCount to 0 and you can make it so it only jumps when count is less than 1.

    // Use this for initialization
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 myVel = MyRigidbody.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            myVel.x = -Speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myVel.x = Speed;
        }
        else
        {
            myVel.x = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 jForce = new Vector2(0, JumpForce);
            MyRigidbody.AddForce(jForce);
        }
        MyRigidbody.velocity = myVel;
    }
     void OnCollisionEnter2D(Collision2D aCollision)
    {

            if (aCollision.collider.gameObject.tag == "Enemy")
            {
                myHealth = myHealth - 25;
                Debug.Log(myHealth);

                if (myHealth <= 0)
                {
                    myHealth = myHealth + 100;
                    Debug.Log(myHealth);
                    transform.position = origin;

                }
            healthText.text = "Health: " + myHealth;
            }
    }

}
