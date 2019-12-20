using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneNavigator : SingletonMonoBehaviour<SceneNavigator>
{
    // フェード中かどうか
    public bool IsFading
    {
        get {return _fader.IsFading || _fader.Alpha != 0; }
    }

    // ひとつ前と現在、次のシーン名
    // ひとつ前
    private string _beforeSceneName = "";
   
    public string BeforeSceneName
    {
        get
        {
            return _beforeSceneName;
        }
    }

    // 現在
    private string _currentSceneName = "";
    public string CurrentSceneName
    {
        get
        {
            return _currentSceneName;
        }
    }

    // 次
    private string _nextSceneName = "";
    public string NextSceneName
    {
        get
        {
            return _nextSceneName;
        }
    }

    // フェード後のイベント
    public event Action FadeOutFinished = delegate { };
    public event Action FadeInFinished = delegate { };

    // フェード用クラス
    [SerializeField]
    private CanvasFader _fader = null;

    // フェード時間
    public const float FADE_TIME = 0.5f;

    private float _fadeTime = FADE_TIME;

    // 初期化
    protected override void Init()
    {
        base.Init();


        if (_fader == null)
        {
            Reset();
        }

        // 最初のシーン名設定
        _currentSceneName = SceneManager.GetSceneAt(0).name;

        // 永続化してフェード用のキャンバスを非表示に
        DontDestroyOnLoad(gameObject);
        _fader.gameObject.SetActive(false);
    }

    private void Reset()
    {
        // オブジェクトの名前を設定
        gameObject.name = "SceneNavigator";

        // フェード用のキャンバス作成
        GameObject fadeCanvas = new GameObject("FadeCanvas");
        fadeCanvas.transform.SetParent(transform);
        fadeCanvas.SetActive(false);

        Canvas canvas = fadeCanvas.AddComponent<Canvas>();

        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        canvas.sortingOrder = 999;

        fadeCanvas.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        fadeCanvas.AddComponent<GraphicRaycaster>();

        _fader = fadeCanvas.AddComponent<CanvasFader>();
        _fader.Alpha = 0;

        // フェード用の画像作成
        GameObject imageObject = new GameObject("Image");
        imageObject.transform.SetParent(fadeCanvas.transform, false);
        imageObject.AddComponent<Image>().color = Color.black;
        imageObject.GetComponent<RectTransform>().sizeDelta = new Vector2(2000, 2000);
    }

    // シーン変更
    public void Change(string sceneName , float fadeTime = FADE_TIME)
    {
        if (IsFading)
        {
            Debug.LogError("フェード中です...");
            return;
        }

        // 次のシーン名とフェード時間を設定
        _nextSceneName = sceneName;
        _fadeTime = fadeTime;

        // フェードアウト
        _fader.gameObject.SetActive(true);
        _fader.Play(isFadeOut: false, duration: _fadeTime, onFinished: OnFadeOutFinish);

    }

    // フェードアウト終了
    private void OnFadeOutFinish()
    {
        FadeOutFinished();

        // シーン読み込み、変更
        SceneManager.LoadScene(_nextSceneName);

        // シーン名更新
        _beforeSceneName = _currentSceneName;

        _currentSceneName = _nextSceneName;

        // フェードイン開始
        _fader.gameObject.SetActive(true);
        _fader.Alpha = 1;
        _fader.Play(isFadeOut: true, duration: _fadeTime, onFinished: OnFadeInFinish);
    }

    // フェードイン終了
    private void OnFadeInFinish()
    {
        _fader.gameObject.SetActive(false);
 
        FadeInFinished();
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        // イベントにメソッド登録
        SceneNavigator.Instance.FadeOutFinished += OnFinishedFadeOut;
        SceneNavigator.Instance.FadeInFinished += OnFinishedFadeIn;
    }

    // フェードアウトが完了した(シーンの遷移はまだしていない)時に実行される
    private void OnFinishedFadeOut()
    {
        Debug.Log(SceneNavigator.Instance.CurrentSceneName + " から " + SceneNavigator.Instance.NextSceneName + " へ遷移中...");
    }

    // シーンの移動後、フェードインが完了した後に実行される
    private void OnFinishedFadeIn()
    {
        Debug.Log(SceneNavigator.Instance.CurrentSceneName + " に遷移完了！前のシーンは" + SceneNavigator.Instance.BeforeSceneName);
    }
}