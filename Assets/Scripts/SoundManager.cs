﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance = null;

	public AudioClip blockHit;
	public AudioClip paddleHit;
	public AudioClip wallHit;

	private AudioSource soundEffectAudio;

	void Start() {

		if (Instance == null) {
			Instance = this;
		} else if (Instance != this) {
			Destroy (gameObject);
		}

		AudioSource theSource = GetComponent<AudioSource> ();
		soundEffectAudio = theSource;

	}
	public void PlayOneShot(AudioClip clip) {
		soundEffectAudio.PlayOneShot(clip);
	}
}
