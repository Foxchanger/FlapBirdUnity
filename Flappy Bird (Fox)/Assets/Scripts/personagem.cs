using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class personagem : MonoBehaviour
{
    public float forcaImpulso;
    public static bool jogando;
    public Rigidbody2D rb;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
       

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            if (!jogando ) 
            {
                rb.gravityScale = 1.0f;
                jogando = true;
                
            }
            rb.velocity = new Vector2(0.0f, 0.0f);
            rb.AddForce(Vector2.up * forcaImpulso);

            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * 2.0f);

        }
        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        SceneManager.LoadScene("GameScene");
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        placar.pontos++;
    }

}