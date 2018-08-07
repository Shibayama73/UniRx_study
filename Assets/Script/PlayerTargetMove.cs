using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class PlayerTargetMove : MoveBase {

    public float _speed = 1.0f; // 移動速度 m/s

    // Use this for initialization
    void Start()
    {
        // Observable.Return(new Vector3(0, 10, 0)).Subscribe(v => gameObject.transform.position = v);

        //更新(GameObjectが破棄されたら勝手に停止するため安全)
        this.UpdateAsObservable()
            //キーが押されたら(Where:条件)
            .Where(_ => Input.GetKey(KeyCode.UpArrow))
            // 移動する(Subscribe:処理の登録)
            .Subscribe(l => MoveUp(_speed));

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.DownArrow))
            .Subscribe(l => MoveDown(_speed));

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.RightArrow))
            .Subscribe(l => MoveRight(_speed));

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.LeftArrow))
            .Subscribe(l => MoveLeft(_speed));
    }
	
    //↓UniRx導入前
	// Update is called once per frame
    //void Update()
    //{
    //    Vector3 pos = transform.position;
    //    float moveLength = Speed * Time.smoothDeltaTime;
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        pos.z += moveLength;
    //    }
    //    else if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        pos.z -= moveLength;
    //    }
    //    else if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        pos.x -= moveLength;
    //    }
    //    else if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        pos.x += moveLength;
    //    }
    //    transform.position = pos;
    //}

}
