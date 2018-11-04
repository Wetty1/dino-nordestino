using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorObstaculo : MonoBehaviour {

    public List<GameObject> listaDeObstaculos;
    private GameObject obstaculo;
    public float tempo;
    private float contadorTempo;

    float pontosTempo;
    int pontos;
    public Text txtPontos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pontosTempo += Time.deltaTime * 7;
        pontos = (int)pontosTempo;
        txtPontos.text = pontos.ToString();

        contadorTempo -= Time.deltaTime;
		if (contadorTempo <= 0)
        {
            int num = Random.Range(0, listaDeObstaculos.Count);
            obstaculo = listaDeObstaculos[num];
            Instantiate(obstaculo, transform.position, transform.rotation);
            contadorTempo = Random.Range(tempo - 1.5f, tempo + 1.5f);
        }
	}
}
