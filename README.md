-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<p align="center">
  <img width="105" height="115" src="https://github.com/vsafontlopez/elecktAR/blob/main/assets/elecktAR_icon.png">
</p>

<b><p align="center">
  elecktAR
</p></b>

  
<p align="center">
  An open source Android app that proposes a novel approach <br>
  for learning electronics based on Augmented Reality (AR)
</p>


<b><p align="center">
[![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=flat&logo=unity)](https://unity3d.com)
[![Ask Me Anything](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://GitHub.com/vsafontlopez/elecktAR)
</p></b>

<b><p align="center">
![Android](https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white)
![Blender](https://img.shields.io/badge/blender-%23F5792A.svg?style=for-the-badge&logo=blender&logoColor=white)
![Adobe Photoshop](https://img.shields.io/badge/adobe%20photoshop-%2331A8FF.svg?style=for-the-badge&logo=adobe%20photoshop&logoColor=white)
</p></b>

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to install Unity Hub? :arrow_double_down:</b>

1. Navigate to the download page for Unity Hub: https://unity.com/download
2. Click on:
   <p>2.1. Download for Windows and save the file UnityHubSetup.exe</p>
   <p>2.2. Download for Mac and save the file UnitHubSetup.dmg</p>
   <p>2.3. Instructions for Linux</p>
3. Follow the instructions onscreen for guidance through the installation process and setup.
4. Now Unity Hub is open. Navigate to the Installs tab, located on the left hand side, click on the Add button, and choose your Unity Version.
We recommend Unity Version 2020.3.13f1.
   <p>If you can’t find the version, please visit https://unity.com/releases/editor/archive for Long Term Support releases.</p>
5. Unity allows the installation of modules, so make sure that the box is ticked for those modules you need. In this project Microsoft Visual Studio and Android Build Support are used.
6. Unity will take quite a while to install; keep calm and don’t worry!
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to activate a license to use Unity? :heavy_check_mark:</b>

1. Open Unity Hub and sign into your Unity ID using the account icon in the top right of the window. If you don’t have a Unity account, create one by visiting https://id.unity.com.
2. Once logged in, click the cog icon in the top right hand corner and navigate to the License Management tab.
3. Click on SAVE LICENSE REQUEST and save the Unity_lic.alf file with the license.
4. Select the Unity license to activate and click DONE.
5. Click on ACTIVATE NEW LICENSE.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

The project has the Vuforia SDK installed but requires a license key that uniquely identifies the app and enables Vuforia Engine AR features to work properly.

<b>How to create a Vuforia license key? :key:</b>

1. You will need a Vuforia Engine Developer account with a Basic or Premium plan to create license keys; if you have an account, login; otherwise Register: https://developer.vuforia.com/
2. In the Vuforia dashboard, select the Develop tab, and click on Get Basic.
3. Under License Manager tab, add a name for your license key in the License Name* field. Check the confirmation box to accept the conditions of the Vuforia Developer Agreement.
4. Press Confirm, and your new license will appear in the License Manager tab.
4. Click on your application name under the License Manager tab.
5. Copy your license key.
6. Paste it into your license key field given in AR camera (Vuforia Behaviour (Script) – Open Vuforia Engine configuration – App License Key).
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to download eleckt[AR] from GitHub? :arrow_double_down:</b>

1. Navigate to GitHub Repository and locate elecktAR in the search bar on the right of the top corner.
2. Click on the green Code button at the top right and select Download Zip. This will download the entire repository as a zipped folder.
3. Unzip the downloaded folder.
4. Download two files that are larger than 100 MB:
   <p>4.1.1. Locate elecktAR_demo → Library → ArtifactDB.</p>
   <p>4.1.2. Click on the file and click on Raw button, on the right of the top corner.</p>
   <p>4.1.3. Replace the downloaded file in the zipped folder for this one.</p>
   <p>4.2.1. Locate elecktAR_demo → Packages → com.ptc.vuforia.engine-10.2.5.tgz.</p>
   <p>4.2.2. Click on the file and click on Raw button, on the right of the top corner.</p>
   <p>4.2.3. Replace the downloaded file in the zipped folder for this one.</p>
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to add the downloaded project? :heavy_plus_sign:</b>

1. With eleckt[AR] folder downloaded from GitHub to a location of your choosing, open the Unity Hub.
2. With the Projects tab selected, click on ADD to manually add a project.
3. Locate the project folder using the file explorer, then click on Select Folder.
4. The project will immediately appear in the Projects list and be added to the Unity Hub.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to create and add a new flashcard to the project? :art:</b>

1. Navigate to GitHub Repository and locate the folder **flashcards** on the left of the top corner.
2. Click on the file **01_flashcard_template.psd** (obverse) or **02_flashcard_template.psd** (reverse) to download it.
3. Edit the downloaded .psd file in **Photoshop** or **Gimp**.
4. Modify on the file **01_flashcard_template.psd** (obverse) the group of layers called **"Main_text"** (it corresponds to the name of the electrical component) and **"Number"** (a number to identify every flashcard) and the layer **"Symbol"** (it corresponds to the symbol of the electrical component).
5. Modify on the file **02_flashcard_template.psd** (reverse) the same as in the previous step and the layer **"Description"** (brief description of the electrical component).
6. Save the modified file as a .jpg file.
7. Drag the file into the 
8. 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to create and add a new 3d model to the project? :construction:</b>

1. 
2. 
3. 
4. 
5. 
6. 
7. 
8. 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

This version of elecktAR works with twelve scenes to create your own circuits. The circuits 1, 7, and 12 are examples to show how it works.

<b>How to edit a Scene in Unity? :wrench:</b>

1. Select the Scene in Unity to edit.
2. From the hierarchy menu on the left, select ModelTarget → protoboard_model_target_generator.
3. Add to this GameObject the electrical 3d model component of the circuit that you need to create a new electrical circuit.
Various electrical 3D model components are included in electkARs’ GitHub Repository.
4. Place the 3d model over the breadboard 3D model.
5. Repeat steps 3 and 4 until you have created the electrical circuit that you need.
6. Save the changes and enjoy learning.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

<b>How to build the apk file in Unity? :hammer_and_wrench:</b>

1. On Unity Hub, go to the Installs tab and check if Android Build Support is installed in the Unity Version.
   <p></p>
   <p align="center">
   <img width="530" height="190" src="https://github.com/vsafontlopez/elecktAR/blob/main/assets/unity_hub_installs.png">
   </p>
   <p>If Android Build Support isn’t installed in the Unity Version, you have to install it by clicking on the dropdown at the top-right corner of the Unity Version and selecting the Add Modules option.</p>
2. With Android Build Support installed, open the project, go to File → Build Settings, select Android platform, and click on Switch Platform.
   <p></p>
   <p align="center">
   <img width="240" height="238" src="https://github.com/vsafontlopez/elecktAR/blob/main/assets/file_build_settings.png">
   </p>
   <p>When your platform is switched over to Android, the Switch Platform button will be replaced with the Build button.</p>
3. Check that all the Scenes are inserted.
   <p></p>
   <p align="center">
   <img width="730" height="160" src="https://github.com/vsafontlopez/elecktAR/blob/main/assets/scenes.png">
   </p>
5. Click on Build button <img width="85" height="19" src="https://github.com/vsafontlopez/elecktAR/blob/main/assets/build_button.png">, select a location to save your apk file, give it a name and click on Save.
6. Copy the apk file to a device and enjoy. :smile:

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

