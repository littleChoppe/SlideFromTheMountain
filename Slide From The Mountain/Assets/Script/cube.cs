using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	
	public float moveSpeed;
	public float collideRadius;
	
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		transform.Translate (Vector3.right * Time.deltaTime * moveSpeed * horizontal);
	}

	void OnCollisionEnter()
	{
		Collider[] cols = Physics.OverlapSphere (transform.position, collideRadius, IsTree.isTree());
		if (cols.Length > 0) {
			audioSource.Play ();
			Application.LoadLevel(0);
		}
	}
}
