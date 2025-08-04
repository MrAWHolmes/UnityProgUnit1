…or create a new repository on the command line
echo "# UnityProgUnit1" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin git@github.com:MrAWHolmes/UnityProgUnit1.git
git push -u origin main
…or push an existing repository from the command line
git remote add origin git@github.com:MrAWHolmes/UnityProgUnit1.git
git branch -M main
git push -u origin main

1.1 Start your unity 3d engines...
On your desktop (or somewhere else you will remember), right-click > create New Folder, then name it “Create with Code”
Create a new Unity project using the Universal 3D template - remember to use a version of Unity 6.
For a reminder on how to create a new Unity project, you can reference this tutorial.
Name the project “Prototype 1” and set the file location to your new Create with Code folder.
Select Create Project, then wait for Unity to open your new project.

1.2.Import assets and open Prototype 1
Download the Prototype 1 Starter Files, then extract the compressed folder.
Windows: Right-click on the file > Extract All.
Mac: Double-click on the file.
Import the asset package into your Unity project
For a reminder on how to import packages, you can reference this tutorial.
In the Project window, in  Assets > Scenes > double-click on the Prototype 1 scene to open it. 
Delete the Sample Scene without saving.
Right-click and drag to look around at the start of the road.

1.3.Add your vehicle to the scene

In the Project window, open Assets > Course Library > Vehicles, then drag a vehicle into the Hierarchy window. 
Hold right-click and WASD to fly to the vehicle, then try to rotate around it.
With the vehicle selected and your mouse in the Scene view, press F to focus on it.
Hold alt + left-click (on MacOS: option + left-click) to rotate around the focal point or hold alt + right-click to zoom in and out.
Use the scroll wheel to zoom in and out and hold the scroll wheel to pan.
If anything goes wrong, press Ctrl + Z (macOS: Cmd + Z) to undo until it’s fixed.
Important: You will orbit around the last object that you framed in the Scene view. So it’s important that you first Frame the vehicle (by pressing F), and only then try rotating around it.

1.4.Add an obstacle and reposition it

Go to Course Library > Obstacles and drag an obstacle directly into the Scene view
In the Inspector for your obstacle, in the top-right of the Transform component, click the more options button > Reset Property > Position.
In the Inspector, change the XYZ Location to x=0, y=0, z=25
In the Hierarchy, Right-click > Rename your two objects as “Vehicle” and “Obstacle”

1.5.Locate your camera and run the game

Select the Camera in the Hierarchy window, then press F to focus on it.
Press the Play button to run your game, then press the Stop button to exit Play mode.
Note: If you don’t see your camera preview, you need to enable the Cameras option in the overlay menu in the Scene view. 

Camera and eye on bottom toolbar

Note : Play mode / game view /Scene view - changes made dont persist

1.6.Move the camera behind the vehicle
Use the Move and Rotate tools to move the camera behind the vehicle looking down on it
Hold Ctrl/Cmd to move the camera by whole units

1.7.Customize the interface layout
In the upper-right corner, change the layout from “Default” to “Tall”.
Move the Game view beneath the Scene view.
In the Project window, open the dropdown menu in the top-right and select One-column layout.
In the layout Dropdown, save a new Layout and call it “My Layout”.

1.8 
New Functionality
    *Project set up with assets imported
    *Vehicle positioned at the start of the road
    *Obstacle positioned in front of the vehicle
    *Camera positioned behind vehicle
New Concepts & Skills
    *Create a new project
    *Import assets 
    *Add objects to the scene
    *Game vs Scene view
    *Project, Hierarchy, Inspector windows
    *Navigate 3D space
    *Move and Rotate tools
    *Customize the layout 
Next Lesson
    *We’ll really make this interactive by writing our first line of code in C# to make the vehicle move and have it collide with other objects in the scene