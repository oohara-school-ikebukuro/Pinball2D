using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class Flipper : MonoBehaviour
{
    // 左のフリッパーですか？
    [SerializeField] private bool isLeft;

    private HingeJoint2D hinge;

    // 入力処理のためのやつ
    private FlipperInputActions input;
    private bool isPressed = false;

    void Start()
    {
        input = new FlipperInputActions();
        input.Enable();

        // 左矢印入力をしたとき
        input.Player.Flipper_Left.performed += (ctx) =>
        {
            // 左フリッパーなら、押したことにする
            if (isLeft) isPressed = true;
        };

        // 左矢印入力をやめたとき
        input.Player.Flipper_Left.canceled += (ctx) =>
        {
            // 左フリッパーなら、押したことにする
            if (isLeft) isPressed = false;
        };

        // 右矢印入力をしたとき
        input.Player.Flipper_Right.performed += (ctx) =>
        {
            // 右フリッパーなら、押したことにする
            if (!isLeft) isPressed = true;
        };

        // 右矢印入力をやめたとき
        input.Player.Flipper_Right.canceled += (ctx) =>
        {
            // 右フリッパーなら、押したことにする
            if (!isLeft) isPressed = false;
        };
        {
            // Hinge君を取得します
            hinge = GetComponent<HingeJoint2D>();

            // 回転させたいので、useMotorを有効化
            hinge.useMotor = true;

            // 回転角度に制限を付けたいので、useLimitsを有効化
            hinge.useLimits = true;

            // 回転角度制限を設定
            JointAngleLimits2D limits = new JointAngleLimits2D();
            limits.min = -30;
            limits.max = 30;
            hinge.limits = limits;
        }
    }

    private void Update()
    {
        JointMotor2D motor = hinge.motor;

        float power = 4000;
        if(isPressed)
        {
            if (isLeft) motor.motorSpeed = -power;
            else motor.motorSpeed = power;
        }
        else
        {
            if (isLeft) motor.motorSpeed = power;
            else motor.motorSpeed = -power;
        }
        motor.maxMotorTorque = power;
        hinge.motor = motor;
    }
}
