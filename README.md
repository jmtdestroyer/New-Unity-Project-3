# New-Unity-Project-3

FpsSpel

An FPS game made for a school project. The game is not done and will be uppdated later.
Features

    Basic movement dunction
    Basic fire
    Simple particle effects

Set up

1.import project 2.run it in Unity 5.5.1f1
Contribute

You can contribute bye fixing the grenade and the network functions
Upcoming features

    Grenade will be Fixed
    Network functions will added
    more maps will be added

Code example

here some code from characterControll.cs

    ///<summary> Mouse movement X </summary>
    float rotationHogerVanster = Input.GetAxis("Mouse X") * mouseSpeed;
    transform.Rotate(0, rotationHogerVanster, 0);

			///<summary> Mouse movement Y </summary>
    rotationUppNer -= Input.GetAxis("Mouse Y") * mouseSpeed;
    rotationUppNer = Mathf.Clamp(rotationUppNer,-lasvinkel,lasvinkel);
    Camera.main.transform.localRotation = Quaternion.Euler(rotationUppNer,0,0);

Support

If you are having issues, please let me know at jmtdestroyer@gmail.com
License

The project is licensed under the BSD license.
