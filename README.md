# CG Midterm 2

Part 1: added my mesh from Blender, took a little while to make them but I got most of it done. The main character model didnt work though for some reason, so ill have to jsut skip that part.

Part 2: I made a reflection shader (Copying from Tutorial 3). I crabed the cube maps from the Unity store (https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014) 

The bottom part of the shader works my crabbing the camera view and the normal view in order to calculate their cross product and then add the cube map so it only appears in the edges of the view of the camera. It then combines with the texture and color from the top part in order to rap up the model as a whole. I also added a noise map for the UV of the base color so the mountains/volcanoes have more detail to them like rocks and maybe slight asymmetry to them. It also allows them to control the intensity of the reflection and power of their color/texture with the reflection.

<img width="602" height="337" alt="image" src="https://github.com/user-attachments/assets/6b21aa60-164d-458d-ba8a-b99e41f13850" />

<img width="476" height="258" alt="image" src="https://github.com/user-attachments/assets/62ea3923-7ae8-4ce2-ba80-389cf01a53a4" />


Part 7: Added detail to the lava using over time movement on the UV in order to seem like its moving. This makes it looks like its alive just like the one in the video. 

<img width="563" height="300" alt="image" src="https://github.com/user-attachments/assets/8e705817-125b-4c6e-ba40-2b7506bf9a0c" />

<img width="461" height="358" alt="image" src="https://github.com/user-attachments/assets/29cbc321-44ac-4152-85b4-79ca85af6f26" />

<img width="514" height="379" alt="image" src="https://github.com/user-attachments/assets/9a0f54a9-a6d6-4c17-96af-81e6925bcaba" />



