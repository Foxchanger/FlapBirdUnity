﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour {

    public Button botaoInicio;
    Button btn;
	// Use this for initialization
	void Start () {
        btn = botaoInicio.GetComponent<Button>();
        btn.onClick.AddListener(EntrarNoJogo);
	}
	 void EntrarNoJogo()
    {
        SceneManager.LoadScene("GameScene");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
