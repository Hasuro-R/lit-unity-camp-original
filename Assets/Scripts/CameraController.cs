using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject target;
    bool gameOver;
    // Start is called before the first frame update
    void Start() {
        target = GameObject.Find("UnityChan");
    }

    // Update is called once per frame
    void Update() {
        if (!gameOver) {
            transform.position = new Vector3(0, 0, target.transform.position.z) + new Vector3(3.25f, 8.85f, 0f);
        }
    }

    public void SetGameOver() {
        gameOver = true;
    }
}
