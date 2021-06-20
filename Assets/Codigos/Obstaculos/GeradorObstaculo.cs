using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour {

    public List<GameObject> listaDeObstaculos;
    private GameObject obstaculo;
    private float tempo;
    private float contadorTempo;

    private Controle ctl;

    // Use this for initialization
    void Start() {
        ctl = FindObjectOfType<Controle>();
        tempo = ctl.velocidadeJogo / 400;
        contadorTempo = 2f; 
        if (tempo < 2.5f)
            tempo = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
        contadorTempo -= Time.deltaTime;
		if (contadorTempo <= 0)
        {
            int num = Random.Range(0, listaDeObstaculos.Count);
            obstaculo = listaDeObstaculos[num];
            Instantiate(obstaculo, transform.position, transform.rotation);
            contadorTempo = Random.Range(0 + (1300 / ctl.velocidadeJogo), tempo + (2000 / ctl.velocidadeJogo));
        }
	}
}
