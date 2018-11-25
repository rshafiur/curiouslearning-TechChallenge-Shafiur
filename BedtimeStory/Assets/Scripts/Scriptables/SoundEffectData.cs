using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Curious Learning/Sound Effect")]
public class SoundEffectData : ScriptableObject {

    [System.Serializable]
    public class SoundEffect
    {
        public new string name;
        public AudioClip clip;
    }
    [Header("UI")]
    public SoundEffect[] UISoundEffects;

    [Header("Object")]
    public SoundEffect[] ObjectSoundEffects;
}
