using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube 
{
	private float length;
	private float width;
	private float height; 

	public Cube(float l,
	float w, float h) {
		length = l;
		width = w;
		height = h;

	}

	public float GetVolume (){

		return length * width * height;
	}

	public float GetEdgeLength() {

	return Mathf.Pow(GetVolume(), 1f/3f);
	}

	public float GetLength() {
  return length;
}
    public float GetWidth() {
  return width;
}
    public float GetHeight() {
  return height;
   }
  public void SetLength(float newLength) {
    length = newLength;
   }
  public void SetWidth(float newWidth) {
    width = newWidth;
} 
  public void SetHeight(float newHeight) {
    height = newHeight;
}
}
}