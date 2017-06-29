using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

	public State currentState;
	public int[] audioIds;


	public bool CheckCondition(State_ButtenPressed buttenPressed)
	{
		if (buttenPressed == currentState.trueButtenPressed) {
			ChangeStateTo(currentState.trueState);
			return true;
		}else{
			ChangeStateTo(currentState.falseState);
			return false;
		}
	}

	private void  ChangeStateTo(State newState)
	{
		currentState = newState;
		currentState.DoActions(this);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
