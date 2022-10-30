using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PerlinNoiseShaker_enemy : MonoBehaviour
{
    // �P��̃p�[�����m�C�Y�����i�[����\����
    [Serializable]
    private struct NoiseParam
    {
        // �U��
        public float amplitude;

        // �U���̑���
        public float speed;

        // �p�[�����m�C�Y�̃I�t�Z�b�g
        [NonSerialized] public float offset;

        // �����̃I�t�Z�b�g�l���w�肷��
        public void SetRandomOffset()
        {
            offset = UnityEngine.Random.Range(0f, 256f);
        }

        // �w�莞���̃p�[�����m�C�Y�l���擾����
        public float GetValue(float time)
        {
            // �m�C�Y�ʒu���v�Z
            var noisePos = speed * time + offset;

            // -1�`1�͈̔͂̃m�C�Y�l���擾
            var noiseValue = 2 * (Mathf.PerlinNoise(noisePos, 0) - 0.5f);

            // �U�����|�����l��Ԃ�
            return amplitude * noiseValue;
        }
    }

    // �p�[�����m�C�Y��XYZ���
    [Serializable]
    private struct NoiseTransform
    {
        public NoiseParam x, y, z;

        // xyz�����ɗ����̃I�t�Z�b�g�l���w�肷��
        public void SetRandomOffset()
        {
            x.SetRandomOffset();
            y.SetRandomOffset();
            z.SetRandomOffset();
        }

        // �w�莞���̃p�[�����m�C�Y�l���擾����
        public Vector3 GetValue(float time)
        {
            return new Vector3(
                x.GetValue(time),
                y.GetValue(time),
                z.GetValue(time)
            );
        }
    }

    // �ʒu�̗h����
    [SerializeField] private NoiseTransform _noisePosition;

    // ��]�̗h����
    [SerializeField] private NoiseTransform _noiseRotation;

    private Transform _transform;

    // Transform�̏������
    private Vector3 _initLocalPosition;
    private Quaternion _initLocalQuaternion;

    // ������
    private void Awake()
    {
        _transform = transform;

        // Transform�̏����l��ێ�
        _initLocalPosition = _transform.localPosition;
        _initLocalQuaternion = _transform.localRotation;

        // �p�[�����m�C�Y�̃I�t�Z�b�g������
        _noisePosition.SetRandomOffset();
        _noiseRotation.SetRandomOffset();
    }

    // �U������
    private void Update()
    {
        if (Enemy_HPManager.Instance.ishit && !Player_HPManager.Instance.isDead)
        {
            // �Q�[���J�n����̎��Ԏ擾
            var time = Time.time;

            // �p�[�����m�C�Y�̒l����������擾
            var noisePos = _noisePosition.GetValue(time);
            var noiseRot = _noiseRotation.GetValue(time);

            // �eTransform�Ƀp�[�����m�C�Y�̒l�����Z
            _transform.localPosition = _initLocalPosition + noisePos;
            _transform.localRotation = Quaternion.Euler(noiseRot) * _initLocalQuaternion;
        }
    }
}
