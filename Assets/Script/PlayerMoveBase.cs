using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    /// <summary>
    /// 右移動
    /// </summary>
    /// <param name="speed"></param>
    public void MoveUp(float speed)
    {
        //Debug.Log("MoveUp");
        Vector3 pos = transform.position;
        float moveLength = speed * Time.smoothDeltaTime;
        pos.z += moveLength;
        transform.position = pos;
    }

    /// <summary>
    /// 下移動
    /// </summary>
    /// <param name="speed"></param>
    public void MoveDown(float speed)
    {
        //Debug.Log("MoveDown");
        Vector3 pos = transform.position;
        float moveLength = speed * Time.smoothDeltaTime;
        pos.z -= moveLength;
        transform.position = pos;
    }

    /// <summary>
    /// 右移動
    /// </summary>
    /// <param name="speed"></param>
    public void MoveRight(float speed)
    {
        //Debug.Log("MoveRight");
        Vector3 pos = transform.position;
        float moveLength = speed * Time.smoothDeltaTime;
        pos.x += moveLength;
        transform.position = pos;
    }

    /// <summary>
    /// 左移動
    /// </summary>
    /// <param name="speed"></param>
    public void MoveLeft(float speed)
    {
        //Debug.Log("MoveLeft");
        Vector3 pos = transform.position;
        float moveLength = speed * Time.smoothDeltaTime;
        pos.x -= moveLength;
        transform.position = pos;
    }

}
