using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;



public class ProjecileShooter : MonoBehaviour {

    public AudioClip BallRelease;
    private AudioSource source;
    int BallenInGame = 0;


    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    GameObject prefab;
	void Start () {
        prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(BallRelease);
            GameObject projectile = Instantiate(prefab) as GameObject;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
            ++BallenInGame;
            if (BallenInGame > 3)
            {
                projectile.transform.position = transform.position + Camera.main.transform.forward * -2;
            }
            else
            {
                projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            }
        }

        if (BallenInGame > 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
    