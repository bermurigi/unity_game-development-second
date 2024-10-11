using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorGradingController : MonoBehaviour
{
    private ColorGrading colorGradingEffect; // 컬러 그레이딩 효과
    private bool colorGradingEnabled = false; // 컬러 그레이딩 상태, 시작할 때 꺼짐

    void Start()
    {
        // 게임 오브젝트에 연결된 포스트 프로세싱 프로필에서 컬러 그레이딩 효과 가져오기
        PostProcessVolume postProcessVolume = GetComponent<PostProcessVolume>();
        PostProcessProfile profile = postProcessVolume.profile;
        profile.TryGetSettings(out colorGradingEffect);
    }

    void Update()
    {
        // 켜진 상태에서 case 5가 종료되었을 때 컬러 그레이딩 비활성화
        if (colorGradingEnabled && GameManager.Instance.exit != 5)
        {
            ToggleColorGrading(false);
        }
    }

    void ToggleColorGrading(bool enable)
    {
        // 컬러 그레이딩 활성화 여부에 따라 상태 업데이트
        colorGradingEnabled = enable;

        // 컬러 그레이딩 효과가 존재하면 토글
        if (colorGradingEffect != null)
        {
            colorGradingEffect.enabled.value = enable;
        }
    }

    // 컬러 그레이딩 켜기
    public void EnableColorGrading()
    {
        ToggleColorGrading(true);
    }

    // 컬러 그레이딩 끄기
    public void DisableColorGrading()
    {
        ToggleColorGrading(false);
    }
}
