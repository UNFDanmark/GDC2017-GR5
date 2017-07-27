using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public AudioClip[] deathSound;

    public AudioSource Audio;


    public void deathSoundf()
    {
        int lyd = Random.Range(0, deathSound.Length);
        Audio.clip = deathSound[lyd];
        Audio.Play();
            
       
    }
    
}
