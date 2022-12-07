# GED Final

Nathan Woo 100787454

1+0+0+7+8+7+4+5+4 = 36 (even)

The Starter code from the TA was used.

Space - Spawn New Enemy (Object Pooling)
LMB - Invert controls (Command)

## Object Pooling
ObjectPooling is a singleton class.

Object Pooling instantiates a pool of objects on Scene Load, then disables them for later use. 

Whenever a new object needs to be created, the SpawnFromPool function is called and an Object will be enabled and moved to the specifed location.

Pressing space spawns a new enemy.


## Command

An abstract command interface called ICommand was used as the parent of all commands to ensure all commands contain the method Execute().

A command is called by passing the command when needed to the invoker, which calls the Execute method of each Command and stores it into a command list.

A command called InvertAimCommand was created, which inherits ICommand. The Execute function calls a function from the PlayerInputController to invert the camera controls.

When the player misses two ducks in a row, the InvertAimCommand is passed into the invoker, which calls the Execute function and inverts the controls.

As of now, whenever the player presses Left mouse button to attack it will invert the controls if the raycast returns nothing.


As Command has the ability to rebind controls and undo actions, there's also a chance that Command can be implemented to keep track of all the actions that happen in the game and store them as a replay function.




## ScoreManager

(Unable to fully implement, not enough time)

ScoreManager is a singleton instance that contains the Score Value. There are seperate methods that allow the modification of the score within the ScoreManager Class.
The score can be accessed by other classes by using ScoreManager.instance.ChangeScore()

