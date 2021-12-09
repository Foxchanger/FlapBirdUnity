using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float limitex, retornax, velocidade;
    SpriteRenderer sr;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (personagem.jogando)
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
            if (transform.position.x < limitex)
                transform.position = new Vector3(retornax, 0.0f, 0.0f);
        }

    }
}