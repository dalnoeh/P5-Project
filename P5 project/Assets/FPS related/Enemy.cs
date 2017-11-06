
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform dude_death;
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        GameObject enemy = GameObject.Find(Gun.enemyid);
        //var enemydie = GameObject.FindGameObjectsWithTag("GameEnemy");

        float posx = enemy.transform.position.x;
        float posy = enemy.transform.position.y;
        float posz = enemy.transform.position.z;
        float rotx = enemy.transform.rotation.x;
        float roty = enemy.transform.rotation.y;
        float rotz = enemy.transform.rotation.z;
        Instantiate(dude_death, new Vector3(posx, posy, posz), Quaternion.Euler(rotx, roty, rotz));
        Destroy(enemy);

    }
}
