using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour {

    public SoundEffectData soundList;

    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>() as AudioSource;
        source.playOnAwake = false;
    }

    public void ButtonClickSound()
    {
        source.PlayOneShot(soundList.UISoundEffects[0].clip);
    }

    public void BulbOnSound()
    {
        source.PlayOneShot(soundList.ObjectSoundEffects[0].clip);
    }

    public void KnobOpenSound()
    {
        source.PlayOneShot(soundList.ObjectSoundEffects[1].clip);
    }

    public void DoorOpenSound()
    {
        source.PlayOneShot(soundList.ObjectSoundEffects[1].clip);
    }
}
