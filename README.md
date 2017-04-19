# UnityScreenRecorder
Unity Screen Recorder

# READ ME

## Use
This script makes it so that Unity will automatically record screen captures of your game, either whenever you hit Play in the Editor or when you hit the record key. It's perfect for debugging or capturing gameplay to then show off!

It works by saving screenshots from the Player to the game folder. Each time it records it creates a new folder, named by date and time. Paired with a tool like [ffmpeg](https://ffmpeg.org), it can be an effective and easy way to make game recordings.

## Setup
This .cs script is designed to be added as a component to an empty GameObject in your Scene. 

Also included is an Automator workflow, which can be used to convert the frames to a video using [ffmpeg](https://ffmpeg.org). Save the workflow to ~/Library/Services to then be able to right-click on the folder of screenshots and convert it to video.

## Options
Settings can be changed in the Inspector to suit your needs. You can change the frames per second, or set the screenshot size to much larger (great for high resolution screenshots). You can toggle whether Unity will capture screenshots immediately when you hit Play in the Editor, or if it waits for input before starting to record. You can also change which key starts or stops the recording.

## Sharing is caring!
If you fork this and make it even cooler, I'd love to see what you've done! Send me an email at ctrble [at] gmail . com and let me know what you made!
