using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movercenario : MonoBehaviour {
    public float limiteX, retornarX, velocidade;


	// Use this for initialization
	void Start () {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < limiteX)
        {
            transform.position = new Vector3(retornarX, 0.0f, 0.0f);
        }
		
	}
}
