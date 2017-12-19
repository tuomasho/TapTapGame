using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {

    public float lifetime = 2.5f;
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void FixedUpdate()
    {
        lifetime -= Time.deltaTime;

        if(lifetime < 0)
        {
            Destroy(this.gameObject);
            gm.GameOver();
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("BangBang");
        gm.score += 1;
        gm.UpdateScore();
        Destroy(this.gameObject);
    }
}
