using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class TouchDetection : MonoBehaviour {
	public GameObject messageBox;

	public GameObject messageBox2;
	public GameObject messageBox3;

	public GameObject messageBox4;
	public GameObject note;
	public GameObject note2;
	public GameObject note3;
	public GameObject note4;


	public InputField inputFieldRef;
	public InputField inputFieldRef2;
	public InputField inputFieldRef3;
	public InputField inputFieldRef4; 
	public AudioSource deleteSound;
	private Vector3 fp;   //First touch position
	private Vector3 lp;   //Last touch position
	private float dragDistance;  //minimum distance for a swipe to be registered


	// Use this for initialization
	void Start () {

		Debug.Log("started");
	}

	// Update is called once per frame
	void Update () {


		foreach (Touch touch in Input.touches)

		{
			Ray ray = Camera.main.ScreenPointToRay(touch.position);
			Debug.Log("RAY:" + ray.direction);


			if (touch.phase == TouchPhase.Began)
			{
				fp = touch.position;
				lp = touch.position;
			}
			else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
			{
				lp = touch.position;
			}
			else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
			{
				lp = touch.position;  //last touch position. Ommitted if you use list

				//Check if drag distance is greater than 20% of the screen height
				if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
				{//It's a drag
					Debug.Log("Drag");
					Debug.Log("touchphase position:" + touch.position);
					RaycastHit hit = new RaycastHit();

					if (Physics.Raycast(ray, out hit, 1000))
					{
						Debug.Log("touched " + hit.transform.name);
						if (hit.transform.name.ToString () == "ImageTarget1Cube") {
							note.SetActive(false);
							inputFieldRef.text = "";
							deleteSound.Play ();
						}
						if (hit.transform.name.ToString () == "ImageTarget2Cube") {
							note2.SetActive(false);
							inputFieldRef2.text = "";
							deleteSound.Play ();
						}
						if (hit.transform.name.ToString () == "ImageTargetCube3") {
							note3.SetActive(false);
							inputFieldRef3.text = "";
							deleteSound.Play ();
						}
						if (hit.transform.name.ToString () == "ImageTargetCube4") {
							note4.SetActive(false);
							inputFieldRef4.text = "";
							deleteSound.Play ();
						}else {
						}
					}



				}
				else
				{   //It's a tap as the drag distance is less than 20% of the screen height
					Debug.Log("Tap");
					Debug.Log("touchphase position:" + touch.position);
					RaycastHit hit = new RaycastHit();

					if (Physics.Raycast(ray, out hit, 1000))
					{
						Debug.Log("touched " + hit.transform.name);
						if (hit.transform.name.ToString () == "ImageTarget1") {
							messageBox.SetActive (true);

						}
						if (hit.transform.name.ToString () == "ImageTarget2") {
							messageBox2.SetActive (true);
						}
						if (hit.transform.name.ToString () == "ImageTarget3") {
							messageBox3.SetActive (true);
						}
						if (hit.transform.name.ToString () == "ImageTarget4") {
							messageBox4.SetActive (true);
						}else {
						}
					}
				}
			}
		}

	}
}