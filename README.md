# Unity-JustTheBasics
Unity - Just the Basics. A very basic skeleton with helpful examples to build any game project from

## Intro

This project includes a Main Menu, a Gameplay scene, and a Game Over scene. The Gameplay scene contains 2 bunnies, controllable by 2 separate players. When one bunny eats a carrot, it moves to the Game Over scene. This project showcases all of the basic elements you'll need to a create a game, including: collision events, UI buttons and UI logic, 2D animation, prefabs, scene navigation, input control setup, and basic project setup.

Below, all of these features were already added, but this README will show *how* they were added.

## Build Settings

![Build Settings Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/addopenscene.png)

After building any project, you won't be able to see your scenes unless you add them to your build settings! To do so, open each scene file, then go to File > Build Settings, and click "Add Open Scenes."

## UI Buttons and OnClick events

To create your first button, go to GameObject > UI > Button. This will also create a UI Canvas if you do not already have one.

![UI Button Creation Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/uibutton.png)

Select the Button, and in the Hierarchy, find the "On Click ()" field. The left field is where you can select any of your scripts. On the right, you can select the public function from that script to run. In this example, the buttons will launch public functions to move between scenes. Very handy for a main menu or game over scene.

![On Click Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/onclick.png)

## Setting up an Animation

First, have several animation images on hand. For example, four separate images for a running person.

Create a Sprite, then add an "Animator" component to it by clicking on "Add Component" in the Inspector panel. Now, open up the "Animation" tab by clicking on Window > Animation. Keep in mind Animator and Animation are two different things here. Make sure your new Sprite is selected in the Hierarchy. In the Animation tab, click on "Create" to get started. Save your animation somewhere sensible. Next, drag all of your animation images from the Project Window into the Animation window. In the top left you will see a number field labeled "Samples." This will essentially adjust your animation speed. If you have a low number of animation frames, you will likely need to set this value to a lower number. Also in this Animation tab, we can rearrange our frames to make sure our sprite is animating how we want it to.

![Animation Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/anim.png)

## Setting up Controls

Set up controls using the Input Manager. Separate values can be used for separate players.

![Controller Setup Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/input.png)

## About Prefabs

Prefabs can be made simply by dragging any GameObject to a "Prefabs" folder in your Project panel. Prefabs allow to easily create multiples of the same object, like our carrot here. If one prefab is changed (and changes are saved/applied), all prefabs will include those changes.

![Prefabs Example](https://raw.githubusercontent.com/sirnameless/Unity-JustTheBasics/master/readmefiles/prefabs.png)
