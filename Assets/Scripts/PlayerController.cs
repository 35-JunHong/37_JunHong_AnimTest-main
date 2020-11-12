using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;

    float speed = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //forward
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playerAnim.SetBool("isStrafe", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        //backwards
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playerAnim.SetBool("isStrafe", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        //left
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 270, 0);
            playerAnim.SetBool("isStrafe", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        //right
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            playerAnim.SetBool("isStrafe", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        //attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("isAttack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("isAttack", false);
        }
    }

    //collision on cube
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ("Barrier"))
        {
            playerAnim.SetTrigger("trigDeath");
        }
    }
}
