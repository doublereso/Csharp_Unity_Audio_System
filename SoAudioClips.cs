//Part of the Unity Audio System project by Petr Yakyamsev
//github.com/doublereso/Csharp_Unity_Audio_System

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Clip Set", menuName = "AudioCustom/Clip Set")]
public class SoAudioClips : ScriptableObject 
{
    [Range(0.0f, 5.0f)]
    public float delaySec = 0.0f;
    [Range(-80.0f, 0.0f)]
    public float volumeDb = 0.0f;
    [Range(0.0f, 6.0f)]
    public float randomVolumeDb = 0.0f;
    [Range(-12.0f, 12.0f)]
    public float pitchSt = 0.0f;
    [Range(0.0f, 6.0f)]
    public float randomPitchSt = 0.0f;

    [Space(10)]

    public AudioClip[] clips;
    [System.NonSerialized]
    public int indexClipLastPlayed = 0;
    [System.NonSerialized]
    public int indexClipToPlay = 0;
    
}
