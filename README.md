# Unity-Light-Folder-System

As my Unity Game Project grew, I wanted a system to make folder in my Hierarchy so I could organize my scenes.

I looked a little online and found good solution but not free : https://assetstore.unity.com/packages/tools/utilities/hierarchy-folders-157716

and also free solutions but it looked overkilled for just organizing my scene hierarchy : https://github.com/xsduan/unity-hierarchy-folders 

So I made my own System consisting of only one cs file. 

Installation and How to use :

-Copy/Past the file HierarchyFolder.cs into your script repository.

-Add a new tag "Folder" and give that tag to every folder in your Scene, even the SubFolder

-Add the script to each Root Folder, and don't leave a blank in the folder hierarchy ( no Folder-> GameObject -> Folder, where -> is parent of )

On game launch, the script will go through the hierarchy recursively to remove parenting and deleting the folder so every object in the folder hierarchy are still in the scene but at the root as excpected.

I didn't try to safe proof exotic hierarchy where the folder chain is broken, just stick to basic folder->Subfolder->ect.. structure.

https://user-images.githubusercontent.com/116562217/197523475-4b3139a6-b237-45e5-ad88-b0a367274ecd.mp4
