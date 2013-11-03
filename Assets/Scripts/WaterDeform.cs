using UnityEngine;
using System.Collections;

public class WaterDeform : MonoBehaviour {
	
	MeshFilter mf; 
	Vector3[] baseVertices; 
	Vector3[] workingCopy;
	public float waveheight;
	public float wavesize;

	// Use this for initialization
	void Start () {
		
		mf = GetComponent<MeshFilter>(); 
		baseVertices = mf.mesh.vertices;
	
	}
	
	// Update is called once per frame
	void Update () {
		//every frame, start with a fresh copy of the untouched plane, remember with the original plane 
		workingCopy = baseVertices;
		
		for (int i = 0; i<workingCopy.Length; i++) {
			workingCopy[i] = baseVertices[i] + Vector3.up * Mathf.Sin((Time.time + i) *wavesize) *waveheight;  //access individual pieces of workingcopy[i] 
		}
		
		//stuff data back into meshFilter 
		mf.mesh.vertices = workingCopy; 
		
		//recalculate normals 
		mf.mesh.RecalculateNormals();
		
		//visualize normals 
		for(int i = 0; i <mf.mesh.vertices.Length; i++) {
			Debug.DrawRay(mf.mesh.vertices[i], mf.mesh.normals[i]);
		}
	
	}
}
