using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyBricks : MonoBehaviour
{

    public int Health = 100;
    private int maxHealth;
    private int roundedDamage;
    private int healthBefore;
    private int healthAfter;
    private int healthAfgetrokken;
    public Text scoreText;
    private static int score;
    private int scoreMultiplier = 1;

    // Use this for initialization
    void Start()
    {
        score = 0;
        SetScoreText();
        maxHealth = Health;
    }
    public virtual void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() == null) return;

        float damage = col.gameObject.GetComponent<Rigidbody>().velocity.magnitude * 10;
        roundedDamage = (int)damage;
        //if (roundedDamage < (maxHealth * .1)) return;

        healthBefore = Health;
        //decrease health according to magnitude of the object that hit us
        Health -= roundedDamage;
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
        int roundedScore = score;
        scoreText.text = "Score: " + roundedScore.ToString();
    }
}
