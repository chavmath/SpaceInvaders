using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] GameObject pauseMenu;
	[SerializeField] AudioSource audioSource; // Aseg�rate de asignar esto en el editor

	private void Start()
	{
		// Aseg�rate de tener asignado el AudioSource en el editor
		if (audioSource == null)
		{
			Debug.LogError("AudioSource no est� asignado. As�gnalo en el editor.");
		}
	}

	public void Pause()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0;

		if (audioSource != null && audioSource.isPlaying)
		{
			audioSource.Pause();
		}
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
		Time.timeScale = 1;

		if (audioSource != null && audioSource.isPlaying)
		{
			audioSource.Stop();
		}
	}

	public void Continue()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1;

		if (audioSource != null && !audioSource.isPlaying)
		{
			audioSource.Play();
		}
	}
}
