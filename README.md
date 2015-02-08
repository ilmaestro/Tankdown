# mini-tank game in Unity
TANK madness, Unity3d

## Game Overview
This is a quick design and development exercise in Unity3d. Meant to help develop some of the following skills:
1. Creating basic 3d objects in Unity
2. Semi-Complex player control - why I chose a tank
3. Camera control
4. Multi-player support
5. State management
6. Event management
7. Possible Oculus integration

### Philosophy
Simplicity, with a small degree of an interesting look. In otherwords we're going for things that are simple to build, but can also have some interesting visual appeal. It will be important to create an interesting terrain that gives players the ability to employ some strategy in trying to destory the opponent.

The basic game feel should be similar to a 3rd person death match.  

## Features

### General
Starting out each tank is equipped with basic movement and basic weapon.  Users will initially be focused on finding and shooting at opponents. 

Basic tanks with basic terrain, tanks should have the ability to upgrade and get more powerful attributes like:
1. faster treads
2. longer range weapons
3. more powerful weapons

### Multi-Player
* The main goal is to allow many players (2-20) to join in a single game. Each player will drive a single tank without allies.
* Bare bones game lobby: click JOIN, and be randomly thrown into a game
* No chat support or communication support with other players

### Gameplay
* Game start
    * Edit profile: Name, Color 
    * Click START
* Game controls
    - ESC: quit
    - UP/DOWN: speed inc/dec
    - RIGHT/LEFT: Direction
    - FIRE1: Fire weapon
* Tank controls
    * Speed: increase, decrease
    * Turn: Right, Left
* Weapon controls
    * Basic: Fire only (points in Forward direction only, locked angle and distance)
    * Advanced:
        * Direction: Left/Right
        * Angle: 0-45 degrees
        * Distance: 50 to 500 meters
* Damage
    * Player Health [0 - 100]
    * Weapon damage [5 - 20]
    * When a tank is hit, Damage amount gets subtracted from Health
* Map
    - Obstacles: rocks, buildings, walls
    - Terrain: grass
* Spawning
    * Players initially spawn near spawnpoints
    * Spawnpoints are randomly assigned to key locations pre-specified on the map
* Death
    * Player dies when health reaches zero
    * Player respawns at nearest spawnpoint

## Objects
* Player: 
    - Profile: Name, Color
    - Unit: reference to current unit/tank
    - Number of Kills
    - Number of Spawns
* Unit: base tank class
    - Properties
        - Name
        - Description
        - Health
        - Damage
        - MovementSpeed
        - ReloadTime
    - Event Handlers
        + ChangeSpeed
        + Turn
        + Fire
* Unit/SmallTank: small, fast, but low damage
* Unit/LargeTank: large, slow, but high damage
* Obstacle: base obstacle class
