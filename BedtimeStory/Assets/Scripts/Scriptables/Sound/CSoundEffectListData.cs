using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundEffectAnother", menuName = "Curious Learning/AnotherSoundEffect")]
public class CSoundEffectListData : ScriptableObject
{
    [System.Serializable]
    public class CSoundEffectData
    {
        public AudioClip clip;
        public string type;
    }
    [Header("UI")]
    public CSoundEffectData[] UISoundEffects;
    [Header("Weapon")]
    [Space]
    public CSoundEffectData[] weaponSoundEffects;
    [Header("Environment")]
    [Space]
    public CSoundEffectData[] environmentSoundEffects;
}
