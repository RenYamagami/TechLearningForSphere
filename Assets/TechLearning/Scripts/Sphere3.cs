using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere3 : MonoBehaviour {

	public GameObject point;
	List<GameObject> points = new List<GameObject>();

	public float radius =3;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 360; i++) {
			float x = radius * Mathf.Sin (i) +Random.Range(1,-1);
			float y = radius * Mathf.Cos (i) +Random.Range(1,-1);
			float z = 1;
			points.Add((GameObject)Instantiate (point, this.transform.position+new Vector3 (x, y , z), 
				Quaternion.identity));
		}

		for (int i = 0; i < points.Count; i++) {
			points [i].transform.parent = this.transform;
		}

	}


}
