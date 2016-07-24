using UnityEngine;

public class VoxelStencil : MonoBehaviour {

	protected bool fillType;
	protected int centerX, centerY, radius;

	public virtual void Initialise (bool fillType, int radius) {
		this.fillType = fillType;
		this.radius = radius;
	}

	public virtual void SetCenter (int x, int y) {
		centerX = x;
		centerY = y;
	}

	public virtual bool Apply (int x, int y, bool voxel) {
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
