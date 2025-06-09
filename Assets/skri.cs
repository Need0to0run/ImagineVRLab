using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceWithPrefab : MonoBehaviour
{
    public GameObject correctPrefab;

    [ContextMenu("Replace Children With Prefab")]
    void Replace()
    {
        foreach (Transform child in transform)
        {
            var oldObj = child.gameObject;
            Vector3 pos = oldObj.transform.position;
            Quaternion rot = oldObj.transform.rotation;
            Vector3 scale = oldObj.transform.localScale;

            GameObject newObj = Instantiate(correctPrefab, pos, rot, transform);
            newObj.transform.localScale = scale;
            DestroyImmediate(oldObj);
        }
    }
}

