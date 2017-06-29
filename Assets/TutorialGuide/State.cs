using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="hao/TutorialGuide/State")]
public class State : ScriptableObject 
{
	public State_ButtenPressed trueButtenPressed;
	public State trueState;
	public State falseState;
	public Action[] actions;
	public int currentAudioId;

	public void DoActions(StateController controller)
	{
		if (actions == null) {
			return;
		}
		for (int i = 0; i < actions.Length; i++) {
			actions[i].Act(controller);
		}
	}

}

public enum State_ButtenPressed
{
	Touchpad,
	Trigger,
	PassKey
};
