﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {

	public string name;

	public AudioClip clip;
	public SoundType soundType = SoundType.none;

	[Range(0f, 1f)]
	public float volume = .75f;

	[Range(.1f, 3f)]
	public float pitch = 1f;

	public bool loop = false;

	public AudioMixerGroup mixerGroup;

	[HideInInspector]
	public AudioSource source;

}

public enum SoundType {Effect, Music, none}
