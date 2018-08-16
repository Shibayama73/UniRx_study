using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinEnemyAttackBase : MonoBehaviour
{
    //攻撃可能かどうか
    private bool _isAttack;

	// Use this for initialization
	void Start () {
        _isAttack = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// 攻撃範囲に入ったかどうか
    /// </summary>
    /// <returns></returns>
    public bool IsInAttackRange(GameObject targetObj)
    {
        //ターゲットが範囲に入ったとき
        if (Vector3.Distance(gameObject.transform.position, targetObj.transform.position) <= 10)
        {
            //Debug.Log("攻撃範囲！！");
            _isAttack = true;
            return true;
        }
        _isAttack = false;
        return false;
    }

    /// <summary>
    /// 攻撃可能かどうか
    /// </summary>
    /// <returns></returns>
    public bool IsAttack()
    {
        return _isAttack;
    }

    /// <summary>
    /// 攻撃する(攻勢、侵略)
    /// </summary>
    public void Aggression()
    {
        Debug.Log("攻撃！！！！");
    }


}
