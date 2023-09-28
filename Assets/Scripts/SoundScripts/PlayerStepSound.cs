using UnityEngine;

public class PlayerStepSound : MonoBehaviour
{

    public AudioClip[] stepSounds;

    public AudioSource AudioSource;


    private void StepSoundPlay() 
    {

        AudioSource.PlayOneShot(stepSounds[Random.Range(0, stepSounds.Length)]);

    }


}
