using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    private enum TurnState {START, PLAYERTURN, ENMEYTURN, WIN, LOSE };
    private TurnState state;

	// Use this for initialization
	void Start () {
        state = TurnState.START;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TurnChange()
    {

    }


}
