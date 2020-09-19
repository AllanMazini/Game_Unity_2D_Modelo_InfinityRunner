using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioContrloller : MonoBehaviour
{

    public AudioClip bg;
    public AudioClip fx1;
    public AudioClip fx2;
    public AudioClip fx3;

    private AudioSource audioSource;
   public static AudioContrloller current;

    // Start is called before the first frame update
    void Start()
    {
        current = this;

        audioSource = GetComponent<AudioSource>();
    }

   public void PlayClip(AudioClip audio){
       audioSource.PlayOneShot(audio);
   }

}
