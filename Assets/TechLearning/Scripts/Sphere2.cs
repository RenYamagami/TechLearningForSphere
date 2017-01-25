using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere2 : MonoBehaviour {

	public GameObject point;
	List<GameObject> points = new List<GameObject>();

	public float radius =3;
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 360; i++) {
			float x = radius * Mathf.Sin (i);
			float y = radius * Mathf.Cos (i);
			float z = 1;
			points.Add((GameObject)Instantiate (point, this.transform.position+new Vector3 (x , y , z), 
				Quaternion.identity));
		}

		for (int i = 0; i < points.Count; i++) {
			points [i].transform.parent = this.transform;
		}

	}

	float n =0;
	// Update is called once per frame
	void Update () {
		
		n += Time.deltaTime * 10;

		this.transform.rotation = Quaternion.Euler (n, n, n);

	}
}
