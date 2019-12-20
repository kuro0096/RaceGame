using System;
using UnityEngine;


public class SingletonMonoBehaviour<T> : MonoBehaviourWithInit where T : MonoBehaviourWithInit
{
    //インスタンス
    private static T _instance;

    //インスタンスを外部から参照する用(getter)
    public static T Instance
    {
        get {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));

                //シーン内に存在しない場合はエラー
                if (_instance == null)
                {

                    Debug.LogError(typeof(T) + " is nothing");

                }

                //発見した場合は初期化
                else
                {

                    _instance.InitIfNeeded();

                }
            }
            return _instance;
        }
    }

    protected sealed override void Awake()
    {

        //存在しているインスタンスが自分であれば問題なし

        if (this == Instance)
        {

            return;

        }
        //自分じゃない場合は重複して存在しているので、エラー
        Debug.LogError(typeof(T) + " is duplicated");
    }
}

public class MonoBehaviourWithInit : MonoBehaviour
{
    //初期化したかどうかのフラグ(一度しか初期化が走らないようにするため)
    private bool _isInitialized = false;

    /// 必要なら初期化する
    public void InitIfNeeded()
    {

        if (_isInitialized)
        {

            return;

        }

        Init();

        _isInitialized = true;

    }
    /// 初期化(Awake時かその前の初アクセス、どちらかの一度しか行われない)
    protected virtual void Init() { }
   
    //sealed overrideするためにvirtualで作成
    protected virtual void Awake() { }
}