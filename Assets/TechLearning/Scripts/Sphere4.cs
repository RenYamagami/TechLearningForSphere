using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere4 : MonoBehaviour {

	public GameObject point;
	List<GameObject> points = new List<GameObject>();

	public float radius =3;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 360; i++) {
			float x = radius * Mathf.Sin (10*i)*Mathf.Cos(i) ;
			float y = radius * Mathf.Sin (10*i)*Mathf.Sin(i);
			float z = radius*Mathf.Cos(i*10);
			points.Add((GameObject)Instantiate (point, this.transform.position+new Vector3 (x , y, z), 
				Quaternion.identity));
		}

		for (int i = 0; i < points.Count; i++) {
			points [i].transform.parent = this.transform;
		}

	}


}
