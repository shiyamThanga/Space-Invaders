using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;

    public AudioSource destroyedSound;


    private void Start()
    {
        destroyedSound = GetComponent<AudioSource>();
    }
    public void takeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            die();
        }
    }

    public void die()
    {
        destroyedSound.Play();
        Destroy(gameObject);

    }


}
