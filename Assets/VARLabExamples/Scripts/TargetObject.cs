using System.Collections;
using System.Collections.Generic;
using TigerTail;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    [SerializeField] private Scoreboard scoreboard;
    public ParticleSystem explosionEffect;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out ThrowableSnowball snowball))
        {
            Debug.Log("Hit by a snowball");
            scoreboard.AddScore(10);
            //
            //
            StartCoroutine(PlayParticleEffects());
            //gameObject.SetActive
            
        }
    }

    private IEnumerator PlayParticleEffects() 
    {
        explosionEffect.Play();
        yield return new WaitForSeconds(0.75f);
        explosionEffect.Stop();
        yield return new WaitForSeconds(0.75f);
        gameObject.SetActive(false);
    }


    public void Awake()
    {
        explosionEffect.Stop();

    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }


    
}
