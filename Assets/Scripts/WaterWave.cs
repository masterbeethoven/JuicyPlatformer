using UnityEngine;
using System.Collections;

public class WaterWave : MonoBehaviour {
    public float scrollSpeed = 0.5F;
    void Update() {
        float offset = Time.time * scrollSpeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector3(-offset,0 ,10));
    }
}