using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestroy : MonoBehaviour {

    public float time = 5f;

    void Start()
    {
        Destroy(this.gameObject, time);
    }
}
