using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    // インプットの登録と破棄
    PlayerAct input;
    void Awake() => input = new PlayerAct();
    void OnDisable() => input.Disable();

    // インプットの有効・無効化
    void OnDestroy() => input.Disable();
    void OnEnable() => input.Enable();


    void Update()
    {
        // スティックの移動を取得して動かす
        var velocity = input.ActionTest.Move.ReadValue<Vector2>();
        Debug.Log($"Move[{velocity}]");

        // ジャンプボタンが押されているか判定して動かす
        var isJumpButtonPressed = (input.ActionTest.Jump.ReadValue<float>() >= InputSystem.settings.defaultButtonPressPoint);
        if (isJumpButtonPressed)
        {
            this.transform.Translate(0.0f, 1.0f, 0.0f);
        }
    }
}
