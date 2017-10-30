using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public Camera cam;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffectEnemy;
    public GameObject impactEffectTarget;

    public float fireRate = 15f;

    public float nextTimeToFire = 0f; 

   

	// Update is called once per frame
	void Update () {
		
        if (Input.GetButtonDown("Fire1") /*&& Time.time >= nextTimeToFire */)
        {
            Shoot();

            //nextTimeToFire = Time.time + 1f/fireRate;
        }

	}

    void Shoot()
    {
       // muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            //Debug.Log(hit.transform.);


            Target target = hit.transform.GetComponent<Target>();
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);

            } else if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            if (enemy != null)
            {
                GameObject impactGO = Instantiate(impactEffectEnemy, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
            else if (target != null)
            {
                GameObject impactGO = Instantiate(impactEffectTarget, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 11f);
            }
            
        }



    }
}
