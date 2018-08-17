using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class MinEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var move = GetComponent<MinEnemyMove>();

        //通常移動
        this.UpdateAsObservable()
            .Subscribe(l => move.NormalMove());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
