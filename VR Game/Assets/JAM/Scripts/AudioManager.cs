using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    // to assign a music source in the unity editor
    [SerializeField] private AudioSource musicSource;

    [SerializeField] private AudioSource soundEffectSource;
    [SerializeField] private AudioClip[] soundEffectClips; // Expose array of sound effects in Unity Editor

    // Dictionaries to store sound effects by name for playing by soundEffectSource
    [SerializeField] private Dictionary<string, AudioClip> soundEffects = new Dictionary<string, AudioClip>();


    private void Awake()
    {

        // plays music when scene starts
        PlayMusic();

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        // Add sound effects from the array to the dictionary
        for (int i = 0; i < soundEffectClips.Length; i++)
        {
            //Debug.Log("SoundEffect: " + soundEffectClips[i].name + " is the name");
            AddSoundEffect(soundEffectClips[i].name, soundEffectClips[i]);
        }
    }

    public void PlayMusic()
    {
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    
    // Add a sound effect to the dictionary soundEffects
    public void AddSoundEffect(string soundEffectName, AudioClip soundEffectClip)
    {
        if (!soundEffects.ContainsKey(soundEffectName))
        {
            Debug.Log("soundEffectName: " + soundEffectName);
            soundEffects.Add(soundEffectName, soundEffectClip);
        }
        else
        {
            Debug.LogWarning("soundEffects.ContainsKey(" + soundEffectName + ")");
        }
    }

    // Play a sound effect by name
    public void PlaySoundEffect(string soundEffectName)
    {
        if (soundEffects.ContainsKey(soundEffectName))
        {
            Debug.Log("soundEffects[soundEffectName]: " + soundEffects[soundEffectName]);
            AudioClip soundEffectClip = soundEffects[soundEffectName];
            soundEffectSource.PlayOneShot(soundEffectClip);
        }
        else
        {
            Debug.LogWarning("Sound Effect: " + soundEffectName + " was not found");
        }
    }

    private void Update()
    {
        // Example: Play a sound effect when the player presses a key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.PlaySoundEffect("useThisElevatorDing");
        }
    }

}
