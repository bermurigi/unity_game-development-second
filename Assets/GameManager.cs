/* using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //기믹
    public GameObject box;
    public GameObject ball;
    public GameObject blood_particle;
    public GameObject hand_paritcle;
    public GameObject flickering_light;
    public GameObject light;
    public GameObject[] Bag_Set;
    public GameObject[] Book_Set;
    public GameObject[] FE;
    public bool head;
    public GameObject announcement;

    private static GameManager _instance;
    public int num;
    public bool answer;

    public TMP_Text text;
    public GameObject clearPanel;


    public int exit=0;

    public bool isback;
    // 인스턴스에 접근하기 위한 프로퍼티
    public static GameManager Instance
    {
        get
        {
            // 인스턴스가 없는 경우에 접근하려 하면 인스턴스를 할당해준다.
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void LateUpdate()
    {
        text.text = exit.ToString();
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        // 인스턴스가 존재하는 경우 새로생기는 인스턴스를 삭제한다.
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        // 아래의 함수를 사용하여 씬이 전환되더라도 선언되었던 인스턴스가 파괴되지 않는다.
        DontDestroyOnLoad(gameObject);
    }


    private void Update()
    {
        if (exit>=5)
        {
            clearPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CHRoom()
    {
        num = Random.RandomRange(1, 12);
        switch (num)
        {
            case 1:     
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = true;
                break;
            case 2:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = true;
                break;
            case 3:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = true;
                break;
            case 4:
                blood_particle.SetActive(true);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = false;
                break;
            case 5:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(true);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = false;
                break;
            case 6:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(true);
                light.SetActive(false);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                announcement.SetActive(false);
                answer = false;
                break;
            case 7:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(false);
                Bag_Set[1].SetActive(true);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = false;
                break;
            case 8:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(false);
                Book_Set[1].SetActive(true);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                answer = false;
                break;
            case 9:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(false);
                FE[1].SetActive(true);
                head = false;
                announcement.SetActive(false);
                answer = false;
                break;
            case 10:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = true;
                announcement.SetActive(false);
                answer = false;
                break;
            case 11:
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(true);
                answer = false;
                break;

        }
           
    }
} */



using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing; // PostProcessing 네임스페이스 추가

public class GameManager : MonoBehaviour
{
    //기믹
    public GameObject box;
    public GameObject ball;
    public GameObject blood_particle;
    public GameObject hand_paritcle;
    public GameObject flickering_light;
    public GameObject light;
    public GameObject[] Bag_Set;
    public GameObject[] Book_Set;
    public GameObject[] FE;
    public bool head;
    public GameObject announcement;

    private static GameManager _instance;
    public int num;
    public bool answer;

    public TMP_Text text;
    public GameObject clearPanel;
    public GameObject gameOverPanel;

    public Material[] mat;
    public MeshRenderer[] wallRend;

    public GameObject[] frame;
    public int exit = 0;
    public int error = 0;

    public bool isback;



    //Game Over시
    public GameObject npc;
    public GameObject enemy;
    public GameObject[] door;
    // 인스턴스에 접근하기 위한 프로퍼티
    public static GameManager Instance
    {
        get
        {
            // 인스턴스가 없는 경우에 접근하려 하면 인스턴스를 할당해준다.
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void LateUpdate()
    {
        text.text = exit.ToString();
        for (int i = 0; i < 2; i++)
        {
            wallRend[i].material = mat[exit];
        }
        
        
    }

    private PostProcessVolume postProcessVolume;
    private ColorGrading colorGrading;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        // 인스턴스가 존재하는 경우 새로생기는 인스턴스를 삭제한다.
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        // 아래의 함수를 사용하여 씬이 전환되더라도 선언되었던 인스턴스가 파괴되지 않는다.
        DontDestroyOnLoad(gameObject);

        postProcessVolume = FindObjectOfType<PostProcessVolume>();
        postProcessVolume.profile.TryGetSettings(out colorGrading);

        // 게임 시작 시에는 색상 보정 비활성화
        ApplyColorGrading(false);

    }


    private void Update()
    {
        if (exit >= 5)
        {
            clearPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if(error>=3)
        {
            npc.SetActive(false);
            enemy.SetActive(true);
            for (int i = 0; i < door.Length; i++)
            {
                door[i].SetActive(false);
            }
        }
    }

    public void CHRoom()
    {
        num = Random.RandomRange(1, 15);
        if (exit == 4)
            num = 1;

        switch (num)
        {
            case 1:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = true;
                Debug.Log("Normal activated");
                break;
            case 2:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = true;
                Debug.Log("Normal activated");
                break;
            case 3:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = true;
                Debug.Log("Normal activated");
                break;
            case 4:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = true;
                Debug.Log("Normal activated");
                break;
            case 5:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = true;
                Debug.Log("Normal activated");
                break;
            case 6:
                ApplyColorGrading(false);
                blood_particle.SetActive(true);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("blood activated");
                break;
            case 7:
                ApplyColorGrading(true);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(true);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("Hand activated");
                break;
            case 8:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(true);
                light.SetActive(false);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("light activated");
                break;
            case 9:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(false);
                Bag_Set[1].SetActive(true);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("bag color activated");
                break;
            case 10:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(false);
                Book_Set[1].SetActive(true);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("book color activated");
                break;
            case 11:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(false);
                FE[1].SetActive(true);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("firePin activated");
                break;
            case 12:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = true;
                announcement.SetActive(false);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("NPC activated");
                break;
            case 13:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(true);
                frame[0].SetActive(true);
                frame[1].SetActive(false);
                answer = false;
                Debug.Log("Sound activated");
                break;
            case 14:
                ApplyColorGrading(false);
                blood_particle.SetActive(false);
                hand_paritcle.SetActive(false);
                flickering_light.SetActive(false);
                light.SetActive(true);
                Bag_Set[0].SetActive(true);
                Bag_Set[1].SetActive(false);
                Book_Set[0].SetActive(true);
                Book_Set[1].SetActive(false);
                FE[0].SetActive(true);
                FE[1].SetActive(false);
                head = false;
                announcement.SetActive(false);
                frame[0].SetActive(false);
                frame[1].SetActive(true);
                answer = false;
                Debug.Log("frame activated");
                break;

        }
           
    }

    private void ApplyColorGrading(bool enable)
    {
        colorGrading.enabled.value = enable;
    }

}
