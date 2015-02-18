using UnityEngine;
using System.Collections;

public class GuiWindowScript : MonoBehaviour 
{
	public Rect guiWindowRect = new Rect(-280, 40, 260, 420);
	public GUISkin guiSkin;
	
	
	private void ShowGuiWindow(int windowID) 
	{
		GUILayout.BeginVertical();
		// ...
		GUILayout.EndVertical();
		
		// Make the window draggable.
		GUI.DragWindow();
	}
	
	
	void OnGUI()
	{
		Rect windowRect = guiWindowRect;
		if(windowRect.x < 0)
			windowRect.x += Screen.width;
		if(windowRect.y < 0)
			windowRect.y += Screen.height;
		
		GUI.skin = guiSkin;
		guiWindowRect = GUI.Window(1, windowRect, ShowGuiWindow, "GUI Window");
	}
	
}
