﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    void Update() {
        transform.position = new Vector3(transform.position.x, transform.position.y, -transform.position.y * 0.1f);     //z ordering
    }
}
