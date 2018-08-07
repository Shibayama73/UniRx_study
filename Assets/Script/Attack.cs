using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Attack : AttackBase {

    //目的位置
    public GameObject _targetObj;

    private MinEnemyMove _navMesh;

    // Use this for initialization
    void Start () {
        _navMesh = GetComponent<MinEnemyMove>();

        //更新(GameObjectが破棄されたら勝手に停止するため安全)
        this.UpdateAsObservable()
            //攻撃範囲に入ったら
            .Where(x => IsInAttackRange(_targetObj) == true)
            //停止する
            .Subscribe(l => _navMesh.Stop());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// ナビメッシュの取得
    /// </summary>
    void GetNavMesh()
    {
        _navMesh = GetComponent<MinEnemyMove>();
    }

}
