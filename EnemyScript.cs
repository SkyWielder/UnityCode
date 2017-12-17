using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 1.0f;
    public float maxLeft;
    public float maxRight;
    public bool turnAround;
    public Vector2 startingPos;
    public Rigidbody2D enemyRigidBody;

    // Use this for initialization
    void Start()
    {
        turnAround = false;
        startingPos = enemyRigidBody.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (turnAround == true)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            Debug.Log("GOING LEFT");
        }

        else if (turnAround == false)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Debug.Log("GOING RIGHT");
        }


        if (transform.position.x >= startingPos.x + maxRight)
        { 
            turnAround = true;
        }

        if (transform.position.x<= startingPos.x - maxLeft)
        {
            turnAround = false;
        }
    }
    void OnCollisionEnter2D(Collision2D spellCollision)
    {

        if (spellCollision.collider.gameObject.tag == "Spell")
        {
            Destroy(gameObject);
        }
    }

}

