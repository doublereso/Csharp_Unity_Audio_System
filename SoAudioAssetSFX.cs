//Part of the Unity Audio System project by Petr Yakyamsev
//github.com/doublereso/Csharp_Unity_Audio_System

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "Asset SFX", menuName = "AudioCustom/Asset SFX")]
public class SoAudioAssetSFX : ScriptableObject
{
    [Header("Audio Tracks and Clips")]
    [Tooltip("How much tracks you want in this asset?")]

    public SoAudioClips[] audioTracks;

    [Space(10)]

    [Header("Settings")]
    [Tooltip("Drop the main settings here")]
    public SoAudioSetMain audioSetMain;
    [Tooltip("Drop 3D settings here")]
    public SoAudioSet3D audioSet3D;

}
