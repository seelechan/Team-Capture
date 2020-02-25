﻿using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Core
{
	public static class Game
	{
		/// <summary>
		/// Quits the game
		/// </summary>
		public static void QuitGame()
		{
#if UNITY_EDITOR
			EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
		}
	}
}
