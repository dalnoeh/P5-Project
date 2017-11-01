
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform dude_death;
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {

        var enemydie = GameObject.FindGameObjectsWithTag("GameEnemy");
        foreach (var GameEnemy in enemydie)
        {
            float posx = GameEnemy.transform.position.x;
            float posy = GameEnemy.transform.position.y;
            float posz = GameEnemy.transform.position.z;
            float rotx = GameEnemy.transform.rotation.x;
            float roty = GameEnemy.transform.rotation.y;
            float rotz = GameEnemy.transform.rotation.z;
            Instantiate(dude_death, new Vector3(posx, posy, posz), Quaternion.Euler(rotx,roty,rotz ));
            Destroy(GameEnemy);
        }
    }
}
