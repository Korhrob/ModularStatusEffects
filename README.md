# ModularStatusEffects
Modular RPG status effects in Unity C#
Made and tested in Unity 2021.3.24f1

# Summary
I made this for my own project to make it easy to add and modify status effects in a lego-like manner.
This does not include a status manager or character script to test with, but hopefully isnt too difficult to change to your needs

# How to use
- Include the namespace by adding "using ModularStatusEffects;" at the top of the file in whatever scripts you want to use this in
- Create new instances (Status Effect Instance) based off existing ModularStatusEffect and apply those to your character or status manager
![alt text](https://github.com/Korhrob/ModularStatusEffects/blob/main/example.png?raw=true "Example")


**How to make status effects**
Right click project folder or click "Assets" from toolbar and choose 
"Create" -> "Modular Status Effect" -> "New Status Effect"

![alt text](https://github.com/Korhrob/ModularStatusEffects/blob/main/step1.png "Step1")
![alt text](https://github.com/Korhrob/ModularStatusEffects/blob/main/step2.png "Step2")

Select the created scriptable object, change the parameters and press "Add Module"
If you downloaded the files you can use existing modules or create new ones, pick any you like or add multiple and adjust their values

![alt text](https://github.com/Korhrob/ModularStatusEffects/blob/main/step3.png?raw=true "Step3")
  

**How to make new modules**
Copy the ComponentExample C# script and change the name to whatever you want and implement the logic where needed

![alt text](https://github.com/Korhrob/ModularStatusEffects/blob/main/step4.png "Step4")

Right click project folder or click "Assets" from toolbar and choose 
"Create" -> "Modular Status Effect" -> "Status Effect Component" -> your component
