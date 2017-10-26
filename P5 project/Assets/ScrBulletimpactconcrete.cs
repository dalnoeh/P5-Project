using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrBulletimpactconcrete : MonoBehaviour {
    public GameObject ParSmoke;
    public GameObject ParSmokepuff;
    
    // Use this for initialization
    void Start () {

        float posx = transform.position.x;
        float posy = transform.position.y;
        float posz = transform.position.z;
        GameObject ParBlood = Instantiate(ParSmoke, new Vector3(posx, posy, posz), Quaternion.identity);
        GameObject ParBloods = Instantiate(ParSmokepuff, new Vector3(posx, posy, posz), Quaternion.identity);

        Destroy(ParBlood, 11f);
        Destroy(ParBloods, 11f);

    }
	
	// Update is called once per frame
	void Update () {
       

    }
}
