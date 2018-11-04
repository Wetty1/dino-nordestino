using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoChao : MonoBehaviour {

    public float velocidade;
    [SerializeField]
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direcao = new Vector2(-velocidade * Time.deltaTime, 0);
        rb.velocity = direcao;

        if (transform.position.x < -20f)
        {
            transform.position = new Vector2 (20f, transform.position.y);
        }
	}
}
