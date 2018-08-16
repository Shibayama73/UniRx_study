using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class MinEnemyAttack : MinEnemyAttackBase
{
    //目的位置
    public GameObject _targetObj;
    //ザコ敵の移動情報
    private MinEnemyMove _move;

    // Use this for initialization
    void Start () {
        //ザコ敵の移動情報の取得
        _move = GetComponent<MinEnemyMove>();

        //更新(GameObjectが破棄されたら勝手に停止するため安全)
        this.UpdateAsObservable()
            //攻撃範囲に入ったら
            .Where(x => IsInAttackRange(_targetObj) == true)
            //停止する
            .Subscribe(l => _move.Stop());

        this.UpdateAsObservable()
            //攻撃可能なら
            .Where(x => IsAttack() == true)
            //攻撃する
            .Subscribe(l => Aggression());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// ナビメッシュの取得
    /// </summary>
    void GetNavMesh()
    {
        _move = GetComponent<MinEnemyMove>();
    }

}
