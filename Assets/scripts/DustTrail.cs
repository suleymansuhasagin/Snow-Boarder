using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    SurfaceEffector2D surfaceEffector2D;
    EdgeCollider2D edgeCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        edgeCollider2D = FindObjectOfType<EdgeCollider2D>();
    }
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticles.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
    }
}
