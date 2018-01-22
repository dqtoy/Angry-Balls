using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyBricks : MonoBehaviour
{

    public float Health = 100f;
    private float healthBefore;
    private float healthAfter;
    private float healthAfgetrokken;
    public Text scoreText;
    private static float score;
    private float scoreMultiplier = 10;

    // Use this for initialization
    void start()
    {
        score = 0;
        SetScoreText();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() == null) return;

        float damage = col.gameObject.GetComponent<Rigidbody>().velocity.magnitude * 10;

        healthBefore = Health;
        //decrease health according to magnitude of the object that hit us
        Health -= damage;
        //if health is 0, destroy the block
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Health = 0;
        }
        healthAfter = Health;
        healthAfgetrokken = healthBefore - healthAfter;
        score = score + healthAfgetrokken * scoreMultiplier;
        SetScoreText();
    }

    void SetScoreText()
    {
        int roundedScore = (int)score;
        scoreText.text = "Score: " + roundedScore.ToString();
    }
}
