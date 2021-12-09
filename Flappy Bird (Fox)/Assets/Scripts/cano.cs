using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cano : MonoBehaviour {
    public float velocidade, limiteSuperior, limiteInferior;
    Vector3 posicaoInicial;
    float limitex;
	// Use this for initialization
	void Start () {
        posicaoInicial = transform.position;
        limitex = posicaoInicial.x * -1;
	}
	
	// Update is called once per frame
	void Update () {
        if (personagem.jogando)
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
            if (transform.position.x < limitex)
            {
                transform.position = new Vector2(
                    posicaoInicial.x, Random.Range(limiteInferior, limiteSuperior));
            }
        }
	}
}
