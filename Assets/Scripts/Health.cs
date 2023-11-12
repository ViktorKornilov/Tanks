using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public bool autoDestroy = true;

    public int particleCount;
    public GameObject particle;

    public void Damage()
    {
        hp--;
        if (hp == 0) Die();
    }

    public void Die()
    {
        if(autoDestroy)Destroy(gameObject);

        for (int i = 0; i < particleCount; i++)
        {
            var offset = Random.insideUnitSphere;
            Instantiate(particle,transform.position + offset,transform.rotation);
        }
    }
}