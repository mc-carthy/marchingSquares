using UnityEngine;

public class VoxelStencil : MonoBehaviour {

	private bool fillType;
	private int centerX, centerY, radius;

	public void Initialise (bool fillType, int radius) {
		this.fillType = fillType;
		this.radius = radius;
	}

	public void SetCenter (int x, int y) {
		centerX = x;
		centerY = y;
	}

	public bool Apply (int x, int y) {
		return fillType;
	}

	public int xStart {
		get {
			return centerX - radius;
		}
	}

	public int xEnd {
		get {
			return centerX + radius;
		}
	}

	public int yStart {
		get {
			return centerY - radius;
		}
	}

	public int yEnd {
		get {
			return centerY + radius;
		}
	}

}
