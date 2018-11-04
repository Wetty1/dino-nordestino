using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovimento : MonoBehaviour {

    public Rigidbody2D rb;
    public float jump;
    public Sprite spriteDead;
    public BoxCollider2D abaixado;
    public bool abaixadoBool;

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("Abaixado", abaixadoBool);
        abaixado.enabled = !abaixadoBool;

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < -1f)
        {
            rb.AddForce(new Vector2(0, jump));
        }
        if (Input.GetKey(KeyCode.DownArrow) && rb.velocity.y == 0)
        {
            abaixadoBool = true;
        } else
        {
            abaixadoBool = false;
        }
	}
}
