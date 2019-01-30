using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BasicAudio {
	public class AudioManager : MonoBehaviour {
		
		public Sound[] sounds;

		void Start ()
		{
			for (int i = 0; i < sounds.Length; i++)
			{
				GameObject go = new GameObject("Sound_" + i + "_" + sounds[i].name);
				go.transform.SetParent(this.transform);
				sounds[i].SetSource (go.AddComponent<AudioSource>());
			}
		}

		public void PlaySound (string _name)
		{
			foreach(Sound sound in sounds){
				if(sound.name == _name){
					sound.Play();
					return;
				}
			}
			// no sound with _name
			Debug.LogWarning("AudioManager: Sound not found in list, " + _name);
		}

	}
}