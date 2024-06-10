using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image hpGage;      //HP�Q�[�W�̉摜
    [SerializeField] private Text gameOverText; //�Q�[���I�[�o�[��\������e�L�X�g
    [SerializeField] private Text ContinueText; //�R���e�B�j���[��\������e�L�X�g
    [SerializeField] private AudioClip GameOverSE; //�Q�[���I�[�o�[��\������e�L�X�g
    AudioSource audioSource;


    void Start()
    {
        //�Q�[���J�n���̓e�L�X�g��\�������Ȃ�
        gameOverText.text = "";
        ContinueText.text = "";
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //�Q�[�W�̒l��HP�̊����ɍ��킹�čX�V����
        hpGage.fillAmount = playerHealth.hp / 10f; //"PlayerHealth"�X�N���v�g��"hp"�ϐ����Q�Ƃ��Ă���B
                                                  //Player��HP�̍ő�l��10�Ŋ��邱�Ƃ�HP�̌�����������Ă���B

        //�v���C���[��HP��0�ȉ��ɂȂ�����
        if (playerHealth.hp <= 0)
        {
            //�e�L�X�g�̕�����ύX
            gameOverText.text = "Game Over...";
            ContinueText.text = "Push Enter to Continue";
            audioSource.PlayOneShot(GameOverSE);



            //Enter�L�[�������ꂽ�Ƃ�
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //�V�[����ǂݍ��݂Ȃ���
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
