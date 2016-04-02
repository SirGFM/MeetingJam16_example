using UnityEngine;
using System.Collections;

public class jump_on_key : MonoBehaviour {

	/* The sprite's rigidbody */
    private Rigidbody2D rb;
    
    /** 'Axis' used to trigger jumping */
    public string key_name = "Jump";
    /** 'Force' applied to the player on jump pressed */
    public float jump_force = 5.0f;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		/* There's a bug here! You can press jump on the appex (kinda frame perfect) to jump again */
		if (Input.GetKeyDown(key_name) && Mathf.Abs(rb.velocity.y) < 0.5f) {
			Vector2 v;
			
			v = Vector2.zero;
			v.x = rb.velocity.x;
			v.y = jump_force;
			rb.velocity = v;
		}
	}
}
