using UnityEngine;
using System.Collections;

public class FlockManager : MonoBehaviour {

	public GameObject fishPrefab;
	public int flockDiameter = 20;
	public static int numFish = 10;
	public static GameObject[] allFish = new GameObject[numFish];
	public static Vector3 goalPos = Vector3.down * 100;

	/*
	 * startPos is the location of this object when it is created.
	 * It is used as an offset when creating fish and moving food, 
	 * so the positions are always centered on this transform.
	 * 
	 */
	public static Vector3 startPos;

	void Start () 
	{
		startPos = transform.position;
		goalPos = startPos + (Random.onUnitSphere * flockDiameter);
		MakeFlock();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Random.Range(0,100) == 1)
		{
			goalPos = startPos + (Random.onUnitSphere * flockDiameter);
		}
	}

	void MoveFood(){

		goalPos = startPos + (Random.insideUnitSphere * flockDiameter);

		//foodPrefab.transform.position = goalPos;
	}

	void MakeFlock(){
		Vector3 pos;
		GameObject newFish;

		for (int i = 0; i < numFish; i++) 
		{
			pos = Random.insideUnitSphere * flockDiameter * 2f;
			pos += startPos;
			newFish = Instantiate(fishPrefab, pos, Quaternion.identity);
			newFish.transform.parent = transform;
			allFish[i] = newFish;
			//allFish[i] = (GameObject) Instantiate(fishPrefab, pos, Quaternion.identity);
		}

	}
}
