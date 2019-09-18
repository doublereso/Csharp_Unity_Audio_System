//Part of the Unity Audio System project by Petr Yakyamsev
//github.com/doublereso/Csharp_Unity_Audio_System

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GoAudioData : MonoBehaviour
{
    public SoAudioAssetSFX audioAsset;
    public AudioSource audioSource;
    /*
    private int audioTracksN;
    private int audioClipsN;
    */

    public void Start()
    {
        //audioSource = gameObject.GetComponent<AudioSource>();
        UpdateComponent();
        /*
        audioTracksN = audioAsset.audioTracks.Length;
        Debug.Log("Total amount of Tracks: " + audioTracksN);
        */
#if UNITY_EDITOR
        InvokeRepeating("UpdateComponent", 1.0f, 1.0f);
#endif
    }
    /*
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
            /
        }
    }
    
    IEnumerator PlayClip (int i)
    {
        yield return new WaitForSeconds(audioAsset.audioTracks[i].delaySec);
        audioSource.PlayOneShot(audioAsset.audioTracks[i].clips[audioAsset.audioTracks[i].indexClipToPlay]);
    }
    */
    private void UpdateComponent()
    {
        audioSource.outputAudioMixerGroup = audioAsset.audioSetMain.mixerGroup;
        audioSource.mute = audioAsset.audioSetMain.mute;
        audioSource.bypassEffects = audioAsset.audioSetMain.bypassEffects;
        audioSource.bypassListenerEffects = audioAsset.audioSetMain.bypassListenerEffects;
        audioSource.bypassReverbZones = audioAsset.audioSetMain.bypassReverbZones;
        audioSource.playOnAwake = audioAsset.audioSetMain.playOnAwake;
        audioSource.loop = audioAsset.audioSetMain.loop;
        audioSource.priority = audioAsset.audioSetMain.priority;
        audioSource.volume = audioAsset.audioSetMain.volume;
        audioSource.pitch = audioAsset.audioSetMain.pitch;
        audioSource.panStereo = audioAsset.audioSetMain.stereoPan;
        audioSource.spatialBlend = audioAsset.audioSetMain.spatialBlend;
        audioSource.reverbZoneMix = audioAsset.audioSetMain.reverbZoneMix;
        audioSource.dopplerLevel = audioAsset.audioSet3D.dopplerLevel;
        audioSource.spread = audioAsset.audioSet3D.spread;
        audioSource.rolloffMode = audioAsset.audioSet3D.rolloffMode;
        audioSource.minDistance = audioAsset.audioSet3D.minDistance;
        audioSource.maxDistance = audioAsset.audioSet3D.maxDistance;
    }
}
