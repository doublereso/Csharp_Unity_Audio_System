using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtAudioPlay : MonoBehaviour
{
    public static void SFXoneShot(GoAudioData audioData)
    {
        SoAudioAssetSFX audioAsset = audioData.audioAsset;
        AudioSource audioSource = audioData.audioSource;

        int audioTracksN;
        int audioClipsN;
        audioTracksN = audioAsset.audioTracks.Length;
        //Debug.Log("Total amount of Tracks: " + audioTracksN);

        for (var i = 0; i < audioTracksN; i++)
        {
            audioClipsN = audioAsset.audioTracks[i].clips.Length - 1;

            audioAsset.audioTracks[i].indexClipToPlay = Random.Range(0, audioClipsN);

            if (audioAsset.audioTracks[i].indexClipToPlay == audioAsset.audioTracks[i].indexClipLastPlayed)
            {
                audioAsset.audioTracks[i].indexClipToPlay++;
                if (audioAsset.audioTracks[i].indexClipToPlay > audioClipsN)
                {
                    audioAsset.audioTracks[i].indexClipToPlay = 0;
                }
            }

            audioSource.PlayOneShot(audioAsset.audioTracks[i].clips[audioAsset.audioTracks[i].indexClipToPlay]);

            //Debug.Log("Track number: " + i + ". Number of clip saved to Buffer: " + audioAsset.audioTracks[i].indexClipLastPlayed + ". Clip played: " + audioAsset.audioTracks[i].indexClipToPlay + ". Delay: " + audioAsset.audioTracks[i].delaySec);

            audioAsset.audioTracks[i].indexClipLastPlayed = audioAsset.audioTracks[i].indexClipToPlay;
        }
    }
}
