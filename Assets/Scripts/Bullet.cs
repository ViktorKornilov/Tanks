using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public GameObject particle;
    public int particleCount = 10;

    void Start()
    {
        Destroy(gameObject,2f);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Boom")
        {
            other.gameObject.GetComponent<Health>().Damage();

            for (int i = 0; i < particleCount; i++)
            {
                var offset = Random.insideUnitSphere;
                Instantiate(particle,transform.position + offset,transform.rotation);
            }
        }

        Destroy(gameObject);
        //AudioSource.PlayOneShot(audioClip);
    }
}