using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirckGenerator : MonoBehaviour {

    public int Width;
    public int Height;
    public string BrickSort = "";

	// Use this for initialization
	void Start () {
        GameObject prefab;

        if (this.BrickSort != "")
        {
            prefab = Resources.Load(this.BrickSort) as GameObject;
        }
        else
        {
            prefab = Resources.Load("BrickWood") as GameObject;
        }
        
      
        for(int i = 0; i != Width; i++)
        {
            for(int x = 0; x != Height; x++)
            {
                GameObject brick = Instantiate(prefab) as GameObject;

                float offset = x % 2;

                brick.transform.position = new Vector3(transform.position.x, transform.position.y + x + 0.5f, transform.position.z + i * 2 + offset);
            }
        }
	}

}
