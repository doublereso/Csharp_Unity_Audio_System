using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings 3D", menuName = "AudioCustom/Settings 3D")]
public class SoAudioSet3D : ScriptableObject
{
    [Header("3D Sound Settings")]
    [Tooltip("amount of doppler effect applied to signal, 1 is default")]
    [Range(0.0f, 1.0f)]
    public float dopplerLevel = 1.0f;
    [Tooltip("Sets the spread angle (in degrees) of a 3d stereo or multichannel sound in speaker space. 0 - all sound channels are located at the same speaker location and is mono, 180 - sound channels spread equally between speakers, 360 = sound channels become reversed and hard panned (so if source is on the left, then sound will come from the right). Use it for smoothing the left-to-right position movement (like 45 degrees will make sound a bit more ambiently-wide). 0 is default.")]
    [Range(0.0f, 360.0f)]
    public float spread = 0.0f;
    [Tooltip("Sets how the AudioSource attenuates over distance")]
    public AudioRolloffMode rolloffMode;
    [Tooltip("Outside min distance volume starts to attenuate")]
    public float minDistance = 0.0f;
    [Tooltip("Distance where sound stops attenuating (or completely inaudible for LinearRolloff)")]
    public float maxDistance = 500.0f;

    [Space(10)]

    [Header("From Fmod (needs custom implementation)")]
    [Tooltip("How many sounds can be played atthe same time")]
    [Range(0, 64)]
    public int maxInstances = 64;
    [Tooltip("Pause between next instance of sound. 0 is default)")]
    [Range(0.0f, 60.0f)]
    public float cooldownSec = 0.0f;
    [Tooltip("Randomness in volume. 0 is default")]
    [Range(0.0f, 1.0f)]
    public float randomVolume = 0.0f;
    [Tooltip("Randomness in pitch. 0 is default")]
    [Range(0.0f, 1.0f)]
    public float randomPitch = 0.0f;
}
