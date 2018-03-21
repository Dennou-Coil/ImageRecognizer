using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColliderToUIPanel : MonoBehaviour
{
    void Start()
    {
        BoxCollider box = gameObject.AddComponent<BoxCollider>();
        Vector2 objSize = GetComponent<RectTransform>().sizeDelta;
        box.size = new Vector3(objSize.x,objSize.y,0.1f);
    }
}