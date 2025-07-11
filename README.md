# Cat-Sanctuary


**What is Cat Sanctuary?**

A Horror First Person game that takes place in a haunted cat sanctuary.

Story:

A Person looking for a new job to get away from home finally gets a job at a cat sanctuary. The Cat sanctuary hides its dark past behind the dark veil of night.  Strange Events occur as the night arrives. Now, it is up to you to save the cats by destroying the cursed demon that haunts that sanctuary by collecting the leftover body parts of the previous care taker and by burying them in the town graveyard. 

You can play the game here

* [itch.io](https://rawal-sky.itch.io/cat-sanctuary)

### Game Trailer

[![Watch the trailer](https://img.youtube.com/vi/6tmgfxPicvE/hqdefault.jpg)](https://www.youtube.com/watch?v=6tmgfxPicvE)



## Getting Started

### Prerequisites

- Latest verison of Unity that can be downloaded from [here](https://unity3d.com/get-unity/download). This sample game was tested using Unity 2020.3.20f1.
- The game was tested on Windows 10, but one should be able to port it to other platforms too.

### Setup

You can play the deployed version of the game from the above mentioned itch.io page or download this repository and open it in unity and play the game and also build it by goinf to file / build setting / then click build.



https://github.com/Amna-Hassan04/Cat-Sanctuary/assets/88897729/2387ba49-6c8b-4cbe-8ee4-2ce5c738c3e4



#### Scripts
In the Assets -\> Scripts folder there are many scripts. 
   
 - /Triggers': These are classes that are used to trigger events such as turning lights off, turning on a jump trigger of a zombie etc.
   
 - /Footsteps: These are classes that are used to check which kind of ground the player is standing on and then plays a footstep sound according to it.

 - NoteTrigger.cs: This class pops up a letter UI in front of player.

 - CatDemonErode.cs: this is invoked after player collects the frozen orb. This class erodes the enemy cat demon using a fesnol and erode shader made with unity shader graph.

 - MenuHandler.cs: It manages the main menu of the game. It also manages the buttons.

 - ToggleLight.cs: It turns the flashlight on or off.

 - grave.cs: It checks if player has all the required body parts to bury and then loads the game end scene.



#### Game Inspector

This is the scene in unity where the game level is made. 

https://github.com/Amna-Hassan04/Cat-Sanctuary/assets/88897729/dbe354c3-7400-460d-9222-63e26c657628

The Gmae Objects in the inspector have all the scripts attached to make the game work. 

- Fpscontroller: it has scripts such as footsteps.cs, freezeOrbSpell.cs, and bodyburry.cs attached. On its child objects such as flashlights and audio objects toggle.cs is attached and on audio objects two 
                 scripts for handling ambient audio for the scenes are attached i.e ScaryDramaticAudio.cs and CatDemonAmbient.cs.
- UI Canvases: It has all the texts that will be shown.

- Enemies: It has all the enemy objects as a child. They will be activated by a trigger.
- Temple, Environment, PetCemetry: They have all the models and prefabs that make up the level.
- post processing: This is the main reason for the mood and look of the game. It is the post processing effects of unity's urp that adds effects like vignette, depth of field, color adjustments etc.  






