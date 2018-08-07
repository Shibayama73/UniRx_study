using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinEnemyMove : AttackBase {

    //目的位置
    public GameObject _targetObj;
    //ナビメッシュ
    NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () {
        // NavMeshAgentコンポーネント取得
        _navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        //NavMeshAgentが準備できているなら
        if (_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            //目的地をセット
            _navMeshAgent.SetDestination(_targetObj.transform.position);
            _navMeshAgent.updatePosition = true;
            _navMeshAgent.updateRotation = true;
        }

    }

    /// <summary>
    /// 停止する
    /// </summary>
    /// <returns></returns>
    public void Stop()
    {
        //Debug.Log("STOP");
        _navMeshAgent.updatePosition = false;
        //_navMeshAgent.updateRotation = false;
    }

}
