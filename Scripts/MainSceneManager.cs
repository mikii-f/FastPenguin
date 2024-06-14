using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public GameObject goalText;
    public GameObject menu;
    private bool isMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        goalText.SetActive(false);
        CameraMover.goal = false;
        menu.SetActive(false);
    }

    private void Update()
    {
        //���j���[�\��
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMenu = !isMenu;
            menu.SetActive(isMenu);
        }
        if (isMenu)
        {
            //���X�^�[�g
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("MainScene");
            }
            //�X�e�[�^�X�ݒ�ɖ߂�
            if (Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadScene("CustomScene");
            }
        }
    }

    public IEnumerator Goal()
    {
        CameraMover.goal = true;
        goalText.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("ResultScene");
    }
}