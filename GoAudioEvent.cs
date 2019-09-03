//Part of the Unity Audio System project by Petr Yakyamsev
//github.com/doublereso/Csharp_Unity_Audio_System

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GoAudioEvent : MonoBehaviour
{
    public SoAudioAssetSFX audioAsset;
    private AudioSource audioSource;

    private int audioTracksN;
    private int audioClipsN;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateComponent();
        audioTracksN = audioAsset.audioTracks.Length;
        Debug.Log("Total amount of Tracks: " + audioTracksN);

#if UNITY_EDITOR
        InvokeRepeating("UpdateComponent", 1.0f, 1.0f);
#endif
    }

    public void Update()
    {
        
        if (Input.GetKeyDown("x"))
        {
            for (var i = 0; i < audioTracksN; i++)
            {
                audioClipsN = audioAsset.audioTracks[i].clips.Length -1;

                audioAsset.audioTracks[i].indexClipToPlay = Random.Range(0, audioClipsN);

                if (audioAsset.audioTracks[i].indexClipToPlay == audioAsset.audioTracks[i].indexClipLastPlayed)
                {
                    audioAsset.audioTracks[i].indexClipToPlay++;
                    if (audioAsset.audioTracks[i].indexClipToPlay > audioClipsN)
                    {
                        audioAsset.audioTracks[i].indexClipToPlay = 0;
                    }
                }

                StartCoroutine(PlayClip(i));

                //Debug.Log("Track number: " + i + ". Number of clip saved to Buffer: " + audioAsset.audioTracks[i].indexClipLastPlayed + ". Clip played: " + audioAsset.audioTracks[i].indexClipToPlay + ". Delay: " + audioAsset.audioTracks[i].delaySec);

                audioAsset.audioTracks[i].indexClipLastPlayed = audioAsset.audioTracks[i].indexClipToPlay;

            }
        }
    }

    IEnumerator PlayClip (int i)
    {
        yield return new WaitForSeconds(audioAsset.audioTracks[i].delaySec);
        audioSource.PlayOneShot(audioAsset.audioTracks[i].clips[audioAsset.audioTracks[i].indexClipToPlay]);
    }
    private void UpdateComponent()
    {
        audioSource.outputAudioMixerGroup = audioAsset.mixerGroup;
        audioSource.mute = audioAsset.mute;
        audioSource.bypassEffects = audioAsset.bypassEffects;
        audioSource.bypassListenerEffects = audioAsset.bypassListenerEffects;
        audioSource.bypassReverbZones = audioAsset.bypassReverbZones;
        audioSource.playOnAwake = audioAsset.playOnAwake;
        audioSource.loop = audioAsset.loop;
        audioSource.priority = audioAsset.priority;
        audioSource.volume = audioAsset.volume;
        audioSource.pitch = audioAsset.pitch;
        audioSource.panStereo = audioAsset.stereoPan;
        audioSource.spatialBlend = audioAsset.spatialBlend;
        audioSource.reverbZoneMix = audioAsset.reverbZoneMix;
        audioSource.dopplerLevel = audioAsset.dopplerLevel;
        audioSource.spread = audioAsset.spread;
        audioSource.rolloffMode = audioAsset.rolloffMode;
        audioSource.minDistance = audioAsset.minDistance;
        audioSource.maxDistance = audioAsset.maxDistance;
    }
}
