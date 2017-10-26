using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloodscript : MonoBehaviour {
    public GameObject ParBloodsplat;
    public GameObject ParBloodspurt;
    
    // Use this for initialization
    void Start () {

        float posx = transform.position.x;
        float posy = transform.position.y;
        float posz = transform.position.z;
        GameObject ParBlood = Instantiate(ParBloodsplat, new Vector3(posx, posy, posz), Quaternion.identity);
        GameObject ParBloods = Instantiate(ParBloodspurt, new Vector3(posx, posy, posz), Quaternion.identity);

        Destroy(ParBlood, 1f);
        Destroy(ParBloods, 1f);
        Destroy(this);

    }
	
	// Update is called once per frame
	void Update () {
       

    }
}
