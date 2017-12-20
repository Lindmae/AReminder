using UnityEngine;
using System.Collections;
using Vuforia;

public class MyModelInstantiator : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;

	public Transform myModelPrefab;
	private bool touched;

	// Use this for initialization
	void Start ()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();

		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}

		touched = false;
	}              


	// Update is called once per frame
	void Update(){
		//if(Input.touchCount == 1)
		//{    
			// touch on screen
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				touched = true;

			}
		// }    
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			OnTrackingFound();
		}
	}
	private void OnTrackingFound()
	{
		
			if (myModelPrefab != null)
			{
			if (touched)
			{
				Transform myModelTrf = GameObject.Instantiate(myModelPrefab) as Transform;

				myModelTrf.parent = mTrackableBehaviour.transform;             
				myModelTrf.localPosition = new Vector3(0f, 0f, 0f);
				myModelTrf.localRotation = Quaternion.identity;
				myModelTrf.localScale = new Vector3(1f, 1f, 1f);

				myModelTrf.gameObject.SetActive(true);
			}
		}


	}
}