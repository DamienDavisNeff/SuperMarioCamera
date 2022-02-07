# SuperMarioCamera

In the Super Mario games, the camera follows the player along the x axis when you move forward, but not when you go backwards!

This script brings that camera movement to unity.

Prerequisites

1) Create an empty object, you can call it whatever you want, I called it Camera.
2) Create a square sprite and call it whatever you want, I called it CamBarrier.
3) Set the empty object (Camera) as the parent object of the sprite (CamBarrier).
4) Set the empty object (Camera) as the parent object to your camera (Main Camera).

NOW

1) In your movement code, add a if statement containing your movement that stops the player from moving past the barrier.
`if([playerObject].transform.position.x > [cameraObject].transform.position.x) {
    // your movement code here
}`
2) Apply this script to your empty parent object (Camera).
3) In the inspector, add your player.
4) In the inspector, add your camera (Main Camera).
5) In the inspector, set your x offset (how far your camera will be from the player).

And, I'm pretty sure you are done. If you have any issues, contact `dev.thirdplacestudios@gmail.com`
