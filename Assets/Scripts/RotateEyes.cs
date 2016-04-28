using UnityEngine;
using System.Collections;

public class RotateEyes : MonoBehaviour {

  public Vector3 rotationAxis = new Vector3(0.0f, 1.0f, 0.0f);
  public float rotationAngle = 20.0f;
    public float oldAngle;
	
	// Update is called once per frame
	void Update () {
    // Rotate the eyes around the Y-axis @ 20-degrees/second.
    transform.Rotate(rotationAxis, rotationAngle * Time.deltaTime);
	}


    public void IncreaseSpeed()
    {
        rotationAngle += rotationAngle * 2;
        StartCoroutine("SlowDown");
    }

    IEnumerator SlowDown()
    {
        yield return new WaitForSeconds(3);
        rotationAngle = oldAngle;
    }
}
