using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	//Maximum time to complete level (in seconds)
	public float MaxTime = 60f;

	[SerializeField] private float CountDown = 0;

	void Start()
	{
		CountDown = MaxTime;
	}
	void update()
	{
		//Reduce time
		CountDown -= Time.deltaTime;

	}

	







}
