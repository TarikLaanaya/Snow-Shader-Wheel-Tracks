# Snow Shader

## Description

This game is a little showcase of a snow shader I have created. This was my first time coding a shader and by creating a snow shader I was able to learn about geometry shaders and vertex/pixel shaders.

## Features

All relevant scripts can be found in `Snow-Shader-Wheel-Tracks-/Assets/Scripts/` and shaders found in `Snow-Shader-Wheel-Tracks-/Assets/Shaders/` This game uses various 3rd party assets which helped in showcasing the shaders. Descriptions of each shader and script:

* This game allowed me to learn about the different kinds of shaders such as geometry and vertex shaders. The three shaders I created for this project are:
  
  * `SnowTracks` This shader managed the main qualities of the snow such as colour/texture, smoothness and how mettalic it was. It also allowed the plane the shader would be placed on to tesselate. This was very important for deforming the snow mimicking deep tracks under the cars wheels.
  * `SnowFall` This next shader is what created the effect of snow filling up the tracks. It placed dots on in the places that were defromed by the cars wheels until they were completely filled.
  * Finally one of the most important shaders, `DrawTracks`. This shader would draw the coordinates of each wheel to a splatmap. this splatmap consisted of two colour one representing the original colour of the snow, the other a darker colour representing deeper and more compact snow. This shader would draw to the splatmap which the `SnowTracks` shader would then convert into the texture used on the ground (snow).

* The relevant scripts mostly worked with the shaders providing them with information:

  * The `WheelTracks` script provided information such as brush size, what object would be tesselated and the wheel game objects location. This information would be used by the shaders to draw to the splat map at the correct locations and the desired brush size which could be altered in the editor in real time.
  * `SnowNoise` is a very simmilar script this time working directly with the `SnowFall` shader in order to provide the correct information for the desired effect.

## Viewing The Project

These are the main mechanics and if you would like to see them in action follow these steps:

1. Install Unity Hub from the official [Unity Website](https://unity.com/download), the version this project uses is: 2021.3.4f1.
2. Press the green "code" button located on this repositories home page, from the drop down click download zip.
3. Extract the downloaded file (right click > extract).
4. Open the Unity Hub application and press add located at the top right. Find your extracted folder.
5. The Unity project named "Snow Shader Wheel Tracks" should appear. Click on it.
6. When the application opens the play button is located at the very top.

## Gameplay And Other Projects

If instead you would like to see gameplay footage for the Snow Shader I have posted a video on my YouTube [LataDev](https://www.youtube.com/watch?v=fEtlPdAvisw&t=3s&ab_channel=LaTaDev) and time stamps can be found in the videos description. You can also see footage of my other projects some of which will be posted to github.

## Playing The Game

If you wish to play, you can find a link [here](https://tarik-laanaya.itch.io/snow-shader) to my itch.io and a downloadabe executable of the game.
