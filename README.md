# RotatePlayer Script

The RotatePlayer script is a component for smoothly rotating the player character based on the camera's look direction in Unity. It calculates the dot product between the player's forward direction and the camera's forward direction to determine if the player is looking in the same direction as the camera. If not, it smoothly rotates the player to align with the camera's look direction.

## Features

- Smooth rotation of the player character based on camera's look direction
- Dot product calculation to determine if the player is looking in the same direction as the camera
- Smooth interpolation between current and target rotations

## Getting Started

1. Attach the RotatePlayer script to your player character's GameObject in Unity.
2. Assign the player GameObject to the "player" variable in the script inspector.
3. Configure the desired preciseness value (between 0 and 1) in the inspector to determine the threshold for considering the player looking in the same direction as the camera.

## Usage

- Hold down the right mouse button (Mouse1) to enable rotation.
- While holding the right mouse button, move the camera to change the look direction.
- The player character will smoothly rotate to align with the camera's look direction if the player is not looking in the same direction.

## Notes

- The script assumes that the player GameObject has a forward direction that represents the intended facing direction.
- The camera's forward direction is obtained from the script's transform component.
- The dot product is calculated between the player's forward direction and the camera's forward direction to determine if they are aligned.
- The preciseness value determines the threshold for considering the player looking in the same direction as the camera. A higher value results in a stricter alignment requirement.

## License

This script is released under the [MIT License](LICENSE).

