using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fotseps : MonoBehaviour
{
    public AudioClip[] foostepsOnGrass;
    string material;
    public void PlayFootstepSound()
    {
        AudioSource audio =  GetComponent<AudioSoruce>();
        audio.volume = Random.Range(0.9f, 1.0f);
        audio.pitch = Random.Range(0.9f, 1.0f);
       
            if(material == "Grass")       
                audio.PlayOneShot(foostepsOnGrass[Random.Range(0, foostepsOnGrass.Length)]);
            
        
    }
    void OnCollisionEneter(Collision collision)
    {
        switch (collision.GetTag())
        {
            case "wood":
                break;
            case "Grass":
                material = collision.gameObject.tag;
            default:
                break; 
        }
    }
}
