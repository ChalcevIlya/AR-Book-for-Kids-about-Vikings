using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFx : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource myFx;
    public AudioClip Truefx;
    public AudioClip Falsefx;
    public AudioClip animalnoises;
    public AudioClip forest;
    public AudioClip river;
    
    public void TrueSound()
    {
        myFx.PlayOneShot(Truefx);
    }
    public void FalseSound()
    {

        myFx.PlayOneShot(Falsefx);
    }
    public void AnimalSound()
    {

        myFx.PlayOneShot(animalnoises);
    }
    public void ForestSound()
    {

        myFx.PlayOneShot(forest);
    }
    public void RiverSound()
    {

        myFx.PlayOneShot(river);
    }

}
