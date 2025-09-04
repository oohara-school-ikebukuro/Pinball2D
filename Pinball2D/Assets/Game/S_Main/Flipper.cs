using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class Flipper : MonoBehaviour
{
    // ���̃t���b�p�[�ł����H
    [SerializeField] private bool isLeft;

    private HingeJoint2D hinge;

    // ���͏����̂��߂̂��
    private FlipperInputActions input;
    private bool isPressed = false;

    void Start()
    {
        input = new FlipperInputActions();
        input.Enable();

        // �������͂������Ƃ�
        input.Player.Flipper_Left.performed += (ctx) =>
        {
            // ���t���b�p�[�Ȃ�A���������Ƃɂ���
            if (isLeft) isPressed = true;
        };

        // �������͂���߂��Ƃ�
        input.Player.Flipper_Left.canceled += (ctx) =>
        {
            // ���t���b�p�[�Ȃ�A���������Ƃɂ���
            if (isLeft) isPressed = false;
        };

        // �E�����͂������Ƃ�
        input.Player.Flipper_Right.performed += (ctx) =>
        {
            // �E�t���b�p�[�Ȃ�A���������Ƃɂ���
            if (!isLeft) isPressed = true;
        };

        // �E�����͂���߂��Ƃ�
        input.Player.Flipper_Right.canceled += (ctx) =>
        {
            // �E�t���b�p�[�Ȃ�A���������Ƃɂ���
            if (!isLeft) isPressed = false;
        };
        {
            // Hinge�N���擾���܂�
            hinge = GetComponent<HingeJoint2D>();

            // ��]���������̂ŁAuseMotor��L����
            hinge.useMotor = true;

            // ��]�p�x�ɐ�����t�������̂ŁAuseLimits��L����
            hinge.useLimits = true;

            // ��]�p�x������ݒ�
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
