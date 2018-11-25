using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Curious Learning/Animation Holder")]
public class AnimationList : ScriptableObject {

    [System.Serializable]
    public class AnimationData
    {
        public new string name;
        public AnimationClip clip;
    }
    [Header("Knob")]
    public AnimationClip[] KnobAnimations;

    [Header("Door")]
    public AnimationClip[] DoorAnimations;
}
