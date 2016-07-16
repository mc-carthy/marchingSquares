using UnityEngine;
using System.Collections;

public class VoxelMap : MonoBehaviour {

	public float size = 2f;

	public int voxelResolution = 8;
	public int chunkResolution = 2;

	public VoxelGrid voxelGridPrefab;

	private VoxelGrid[] chunks;

	private float chunkSize, voxelSize, halfSize;

	private void Awake () {
		halfSize = size / 2f;
		chunkSize = size / chunkResolution;
		voxelSize = size / voxelResolution;

		chunks = new VoxelGrid[chunkResolution * chunkResolution];
		for (int i = 0, y = 0; y < chunkResolution; y++) {
			for (int x = 0; x < chunkResolution; x++, i++) {
				CreateChunk (i, x, y);
			}
		}
		BoxCollider box = gameObject.AddComponent<BoxCollider> ();
		box.size = new Vector3 (size * size);
	}

	private void CreateChunk (int i, int x, int y) {
		VoxelGrid chunk = (VoxelGrid)Instantiate (voxelGridPrefab);
		chunk.Initialize (voxelResolution, chunkSize);
		chunk.transform.SetParent (transform);
		chunk.transform.localPosition = new Vector3 (x * chunkSize - halfSize, y * chunkSize - halfSize);
		chunks [i] = chunk;
	}
}
