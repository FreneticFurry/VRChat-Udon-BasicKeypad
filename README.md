# VRChat-Udon-BasicKeypad
a basic keypad that teleports the localplayer if they input the correct code
there's not really any error handling its just meant to be really basic.

how to use:
- import the UnityPackage from [Releases]([https://example.com](https://github.com/FreneticFurry/VRChat-Udon-BasicKeypad/releases)
- place the Keypad prefab into the scene
- click the Keypad object and configure settings

should be pretty straight forward
- Teleport Location: its the location where someone will get teleported to if they input the correct code, it uses a gameobject so place a empty object into the scene and put it where ever (the prefab has this setup.)
- Key Code: default is 123 but you can change it to whatever
- Default Msg: this is the default msg people will see when clearing and when the object is spawned
- Wrong Msg: this is the message seen when someone inputs the wrong cod

as a side note: if you change the name of the key button objects under canvas then the text output will change to that since it uses the game object name but if it isnt a number then it will just clear it (remove IsNumeric from the code if you dont want it to do that.)

<img width="301" height="390" alt="image" src="https://github.com/user-attachments/assets/7820c391-ae84-4e71-b224-4e344cc1dced" />
<img width="494" height="176" alt="image" src="https://github.com/user-attachments/assets/58e50523-7724-4455-a5b5-cc6ed02b7399" />
