using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinEnemyStatus : MonoBehaviour {

    public enum STATUS
    {
        NORMAL, //通常
        ATTACK, //攻撃
    };

    //通信時のデータ送受信できる
    [SerializeField]
    public STATUS CurrentState = STATUS.NORMAL;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
