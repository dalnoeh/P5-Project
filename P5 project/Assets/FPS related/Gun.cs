using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public Camera cam;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    public float fireRate = 10f;

    public float nextTimeToFire = 0f; 

   

	// Update is called once per frame
	void Update () {
		
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            Shoot();

            nextTimeToFire = Time.time + 1f/fireRate;
        }

	}

    void Shoot()
    {
       // muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 11f);
        }



    }
}
