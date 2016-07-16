using UnityEngine;
using System.Collections;

[SelectionBase]
public class VoxelGrid : MonoBehaviour {

	public int resolution;
	public GameObject voxelPrefab;

	private bool[] voxels;
	private float voxelSize;

	public void Initialize (int resolution, float size) {
		this.resolution = resolution;
		voxelSize = size / resolution;
		voxels = new bool[resolution * resolution];

		for (int i = 0, y = 0; y < resolution; y++) {
			for (int x = 0; x < resolution; x++, i++) {
				CreateVoxel (i, x, y);
			}
		}
	}

	private void CreateVoxel (int i, int x, int y) {
		GameObject o = (GameObject)Instantiate (voxelPrefab);
		o.transform.SetParent (transform);
		o.transform.localPosition = new Vector3 ((x + 0.5f) * voxelSize, (y + 0.5f) * voxelSize);
		o.transform.localScale = Vector3.one * voxelSize * 0.9f;
	}
}
