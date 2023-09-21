# Cat-Sanctuary


**What is Cat Sanctuary?**

A Horror First Person game that takes place in a haunted cat sanctuary.


- Real world prizes fulfilled by Amazon.com
- Streamer generated tournaments through Twitch.

Here is a simple game that incorporates the GameOn APIs to give developers an idea on how to create such experiences.

You can play the game here

* [itch.io](https://rawal-sky.itch.io/cat-sanctuary)


## Getting Started

### Prerequisites

- Latest verison of Unity that can be downloaded from [here](https://unity3d.com/get-unity/download). This sample game was tested using Unity 2020.3.20f1.
- The game was tested on Windows 10, but one should be able to port it to other platforms too.

### Setup

In the Assets -\> Scripts folder there are many scripts. 

![.github/images/gameon-unity-sample-game-behaviors.png](.github/images/gameon-unity-sample-game-behaviors.png)

#### Scripts


 - NoteTrigger.cs: This class pops up a letter UI in front of player. 
 - /Triggers': These are classes that are used to trigger events such as turning lights off, turning on a jump trigger of a zombie etc.
 - 
 - /Footsteps: These are classes that are used to check which kind of ground the player is standing on and then plays a footstep sound according to it. 

 - CatDemonErode.cs: this is invoked after player collects the frozen orb. This class erodes the enemy cat demon using a fesnol and erode shader made with unity shader graph.

 - MenuHandler.cs: It manages the main menu of the game. It also manages the buttons. 

#### Game behavior

- FollowCamera.cs: This class is attached to the camera to follow the main player, and to be limited to the level boundaries.

- Goal.cs: This is attached to an object that when touched, would trigger the a win state.

- Level.cs: This is attached to a level to give the object with FollowCamera attached to it boundaries.

- NewSpawnPoint.cs: An object with this attached to it will become the new checkpoint onEnterTrigger.

### Running the Game
- Open the solution with a supported Unity3D Game Engine.
- Start the "mainMenu" scene from the scenes folder

  ![.github/images/gameon-unity-sample-game-mainMenu-scene-selection.png](.github/images/gameon-unity-sample-game-mainMenu-scene-selection.png)

- Make sure that the Scenes in the build settings look like this:

  ![.github/images/gameon-unity-sample-game-build-settings.png](.github/images/gameon-unity-sample-game-build-settings.png)
  
### Security Consideration

The game implements GameOn calls directly from the client, which is not the most secure. Its suggested to use a server in-between the client and the GameOn API.

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

By downloading the GameOn Unity Sample Game, you agree to Amazon’s [Conditions of Use](https://www.amazon.com/gp/help/customer/display.html?nodeId=508088), [Terms of Use](https://www.amazon.com/gp/help/customer/display.html?nodeId=201485660), and [Privacy Notice](https://www.amazon.com/gp/help/customer/display.html?nodeId=468496).

[Bouncy Castle license](http://www.bouncycastle.org/csharp/licence.html) applies to both the source code and the game.
