using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
 

// Make sure the folder has the tag folder, and only the root folder should have this script !
public class HierarchyFolder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(transform.CompareTag("Folder"))
        {
            while(transform.childCount!=0)
            {
                Transform childTrans = transform.GetChild(0);
                if (childTrans.CompareTag("Folder"))
                {
                    childTrans.gameObject.AddComponent<HierarchyFolder>();
                }
                childTrans.parent = null;
            }
            Destroy(gameObject);
        }
    }
}
