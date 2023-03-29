# Snow Shader

## Description

This game is a little showcase of a snow shader I have created. This was my first time coding a shader and by creating a snow shader I was able to learn about geometry shaders and vertex/pixel shaders.

## Features

All relevant scripts can be found in `Snow-Shader-Wheel-Tracks-/Assets/Scripts/` and shaders found in `Snow-Shader-Wheel-Tracks-/Assets/Shaders/` This game uses various 3rd party assets which helped in showcasing the shaders.

* This game allowed me to learn about the different kinds of shaders such as geometry and vertex shaders. The three shaders I created for this project are:
  
  * `SnowTracks` This script managed the main qualities of the snow such as colour/texture, smoothness and how mettalic it was. It also allowed the plane the shader would be placed on to tesselate. This was very important for deforming the snow mimicking deep tracks under the cars wheels.
  * `SnowFall` This next script is what created the effect of snow filling up the tracks. It placed dots on in the places that were defromed by the cars wheels until they were completely filled.
  * Finally one of the most important shaders, `DrawTracks`

* I also learned about using user interface with scripting to create modular and interactive UI. In this case a dialogue system which provided narrative but also a tutorial which would guide the user. The two main dialogue scripts are:

  * `DialogueController` This script worked directly with the `DialogueWindow` script to show and hide the dialogue at the appropriate times.
  * The `DialogueWindow` script controlled the flow of text on the screen so that it would display each letter after a given time. This created a scroll effect which added polish to the User Interface. It also worked with the Unity editor and was dynamic meaning you could add and remove text as you see fit. This greatly improved the time of which it took to complete the project and this system could still be used in my future projects.

## Viewing The Project

There are many more mechanics and if you would like to see them in action follow these steps:

1. Install Unity Hub from the official [Unity Website](https://unity.com/download), the version this project uses is: 2021.3.4f1.
2. Press the green "code" button located on this repositories home page, from the drop down click download zip.
3. Extract the downloaded file (right click > extract).
4. Open the Unity Hub application and press add located at the top right. Find your extracted folder.
5. The Unity project named "Platform Golf" should appear. Click on it.
6. When the application opens the play button is located at the very top.

Notes: To play the game you either need to connect your mobile device, tutorials for which can be found [here](https://www.youtube.com/watch?v=J2T92mzvmHk&ab_channel=DigieraGames)
or you can use the built in Device Simulator tutorials for which are found [here](https://www.youtube.com/watch?v=dI1IEajUg_Y&ab_channel=JehoshaphatAbu)

## Gameplay And Other Projects

If instead you would like to see gameplay footage for platform golf I have posted a video on my YouTube [LataDev](https://www.youtube.com/watch?v=fEtlPdAvisw&t=3s&ab_channel=LaTaDev) and time stamps can be found in the videos description. You can also see footage of my other projects some of which will be posted to github.
