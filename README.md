# Turbo Drift VR Game

A VR-based driving game where players control a vehicle and complete laps while interacting with the environment, featuring dynamic audio and physics-based mechanics.

## Features
- Real-time vehicle control with forward and backward motion.
- Wheel and vehicle sound effects, including changes based on speed.
- Time and lap tracking with best lap recording.
- Dynamic impact sounds for collisions with objects like water and the ocean floor.
- Underwater visual effects triggered by vehicle depth.
- Realistic car movement with adjustable steering.

## Installation
1. Clone or download this repository to your local machine.
2. Open the project in Unity (version 2020.3 or later).
3. Connect a VR headset (e.g., Oculus Rift, HTC Vive, etc.).
4. Run the scene to begin playing the game.

### Script Descriptions:
- **WheelSpinner.cs**: Controls wheel rotation based on vehicle speed.
- **TimeManager.cs**: Tracks and displays lap time, speed, and best lap times.
- **SoundC.cs**: Adjusts car sound volume and pitch based on speed.
- **SelfRotate.cs**: Rotates objects automatically in the scene.
- **PlayImpact.cs**: Plays sound upon impact when vehicle speed exceeds a certain threshold.
- **OceanFloorScript.cs**: Detects collisions with the ocean floor and plays sound effects.
- **MyUnderwater.cs**: Activates underwater post-processing effects when the vehicle reaches a certain depth.
- **HitWaterSplash.cs**: Plays a splash sound when the vehicle enters the water.
- **FrontWheelTurner.cs**: Rotates the front wheels based on input for turning the vehicle.
- **DriveMainScript.cs**: Controls vehicle movement based on input (forward, backward, left, right).
- **StartTriggerScript.cs**: Plays a sound and activates the finish line trigger when the vehicle crosses the start gate.

## Controls
- **WASD or Arrow Keys**: Drive and steer the vehicle.
- **Mouse or VR controller**: Use to interact with menus and UI (if applicable).
  
## Requirements
- Unity 2020.3 or later.
- VR headset (e.g., Oculus Rift, HTC Vive, etc.).
- Basic understanding of Unity development for setting up VR controls.


