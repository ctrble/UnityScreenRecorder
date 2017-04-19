using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Editor_Capture_Controller : MonoBehaviour {

	// Capture frames as a screenshot sequence stored as PNG files in a folder
	// Can them combine them into a video using software like ffmpeg

	public bool recordScreen = true;
	public string recordButton = "9"; // Or set whatever key you want in the Inspector
	public int frameRate = 24; // Remember to also set this in the frames to video script outside of Unity
	public int magnificaton = 0; // Default is 0, Unity will multiply screenshot resolution with magnification x magnification (like 4x4), be wary of performance
	private int elapsedTime;
	private int countOffset;
	private int fileName;
	private string folder;
	private string date;

	void Start () {

		// Set the playback framerate (real time will not relate to game time after this).
		Time.captureFramerate = frameRate;

		if (recordScreen) {

			// For consistent file naming if recording immediately
			countOffset = 2;

			// Prep the folder
			CalculateFolderName ();
		}
	}

	void Update () {

		elapsedTime = Time.frameCount;

		if (Input.GetKeyDown (recordButton)) {

			// Update frame count
			countOffset = elapsedTime;

			// Prep the folder
			CalculateFolderName ();

			// Toggle screen recording on or off
			recordScreen = !recordScreen;
		}
			
		if (Application.isEditor && recordScreen) {

			// Go screenshots, go!
			RecordScreenShots ();
		}
	}

	void RecordScreenShots () {

		// Create the folder
		System.IO.Directory.CreateDirectory(folder);

		// Set file name
		fileName = Time.frameCount - countOffset + 2;

		// Append filename to folder name (format is '0005 shot.png"')
		string name = string.Format("{0}/{1:D04} shot.png", folder, fileName);

		// Capture the screenshot to the specified file.
		Application.CaptureScreenshot(name, magnificaton);
	}

	void CalculateFolderName() {

		// Name the folders by date and time
		date = System.DateTime.Now.ToString("MMddHHmmss");
		folder = "Screenshots/" + date;
	}
}