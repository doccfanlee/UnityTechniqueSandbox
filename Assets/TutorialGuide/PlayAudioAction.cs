using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="hao/TutorialGuide/Actions/PlayAudioAction")]
public class PlayAudioAction : Action 
{
	public override void Act(StateController controller)
	{	
		Debug.Log("Playing audio " + controller.currentState.currentAudioId);
	}

}
