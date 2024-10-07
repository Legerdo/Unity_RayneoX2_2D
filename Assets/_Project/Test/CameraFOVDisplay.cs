using UnityEngine;
using TMPro; // TextMeshPro 관련 라이브러리 추가

public class CameraFOVDisplay : MonoBehaviour
{
    public Camera mainCamera; // 메인 카메라를 할당
    public TextMeshProUGUI fovText; // TextMeshPro 텍스트 컴포넌트 할당

    void Start()
    {
        // 만약 mainCamera가 비어있다면, 기본 메인 카메라를 자동으로 설정
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        if (mainCamera != null && fovText != null)
        {
            // 카메라의 FOV 값을 실시간으로 텍스트에 표시
            fovText.text = "FOV: " + mainCamera.fieldOfView.ToString("F2");
        }
    }
}
