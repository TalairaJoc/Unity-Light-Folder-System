# Unity-Light-Folder-System

As my Unity Game Porject grew, I wanted a system to make folder in my Hierarchy so I could organize my scenes.

I looked a little on the internet and found one good solution but it ain't free : https://assetstore.unity.com/packages/tools/utilities/hierarchy-folders-157716

I also found some free solutions but it looked overkilled for just organize my scene hierarchy : https://github.com/xsduan/unity-hierarchy-folders 

So I made my own System consisting of only one cs file. 

Installation and How to use :

-Copy/Past the file HierarchyFolder.cs into your script repository.
-Add a new tag Folder and give that tag to every folder in your Scene, even the SubFolder
-Add the script to each Root Folder, and don't leave a blank in the folder hierarchy ( no Folder-> GameObject -> Folder, where -> is parent of )

On game launch, the script will go through the hierarchy recursively to remove parenting and deleting the folder so every object in the folder hierarchy are still in the scene but atg the scene root as excpected.

I didn't try to safe proof exoctic hierarcy where the folder chain is broken just stick to basic folder->Subfolder->ect.. structure.
