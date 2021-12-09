using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class placar : MonoBehaviour {
    public Text txtPontos;
    public static int pontos;
	// Use this for initialization
	void Start () {
        pontos = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!personagem.jogando)
        {
            pontos = 0;
        }
        txtPontos.text = pontos.ToString();
		
	}

    
}
