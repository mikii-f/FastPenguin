using UnityEngine;

public class GuideMover : MonoBehaviour
{
    private CharacterManager characterManager;
    private RectTransform playerRect;
    private float myDefaultX;
    private float myDefaultY;
    private float playerDefaultX; 
    private RectTransform myRect;
    // Start is called before the first frame update
    void Start()
    {
        characterManager = GameObject.Find("penguin1").GetComponent<CharacterManager>();
        playerRect = characterManager.GetComponent<RectTransform>();
        myRect = GetComponent<RectTransform>();
        myDefaultX = myRect.anchoredPosition.x;
        playerDefaultX = playerRect.anchoredPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�̈ړ��ɉ������X�e�[�W�K�C�h�̈ړ�(�ړ��䗦�͊T�Z)
        if (!CameraMover.goal)
        {
            myRect.anchoredPosition = new Vector2(myDefaultX + (playerDefaultX - playerRect.anchoredPosition.x) / 16.2f, myDefaultY);
        }
    }
}
