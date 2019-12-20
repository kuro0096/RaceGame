using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // MenuSceneへ遷移
        SceneNavigator.Instance.Change("MenuScene");

        // MenuSceneへ遷移、フェードインとフェードアウトの時間をそれぞれ1.5秒に設定(デフォルトは0.5秒)
        SceneNavigator.Instance.Change("MenuScene", 1.5f);
    }
}
