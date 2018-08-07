using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
            return true;
        }
        return false;
    }


}
