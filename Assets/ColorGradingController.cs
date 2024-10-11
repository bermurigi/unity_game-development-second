using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorGradingController : MonoBehaviour
{
    private ColorGrading colorGradingEffect; // �÷� �׷��̵� ȿ��
    private bool colorGradingEnabled = false; // �÷� �׷��̵� ����, ������ �� ����

    void Start()
    {
        // ���� ������Ʈ�� ����� ����Ʈ ���μ��� �����ʿ��� �÷� �׷��̵� ȿ�� ��������
        PostProcessVolume postProcessVolume = GetComponent<PostProcessVolume>();
        PostProcessProfile profile = postProcessVolume.profile;
        profile.TryGetSettings(out colorGradingEffect);
    }

    void Update()
    {
        // ���� ���¿��� case 5�� ����Ǿ��� �� �÷� �׷��̵� ��Ȱ��ȭ
        if (colorGradingEnabled && GameManager.Instance.exit != 5)
        {
            ToggleColorGrading(false);
        }
    }

    void ToggleColorGrading(bool enable)
    {
        // �÷� �׷��̵� Ȱ��ȭ ���ο� ���� ���� ������Ʈ
        colorGradingEnabled = enable;

        // �÷� �׷��̵� ȿ���� �����ϸ� ���
        if (colorGradingEffect != null)
        {
            colorGradingEffect.enabled.value = enable;
        }
    }

    // �÷� �׷��̵� �ѱ�
    public void EnableColorGrading()
    {
        ToggleColorGrading(true);
    }

    // �÷� �׷��̵� ����
    public void DisableColorGrading()
    {
        ToggleColorGrading(false);
    }
}
