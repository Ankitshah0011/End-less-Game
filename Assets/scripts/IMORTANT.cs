using UnityEngine;

public class AudioManager : MonoBehaviour
{
    void Awake()
    {
        AudioSource[] allAudio = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in allAudio)
        {
            if (a.clip != null)
            {
                // Start BGM automatically
                if (a.clip.name == "BGM")
                {
                    a.playOnAwake = false; // safe
                    a.loop = true;         // loop background music
                    a.Play();              // start it manually
                    continue;
                }

                // Keep FX as is (we’ll play it via script on coin collision)
                if (a.clip.name == "FX")
                {
                    a.playOnAwake = false; // don’t auto-play
                    continue;
                }
            }

            // Stop and disable all other audio
            a.Stop();
            a.playOnAwake = false;
        }
    }
}
