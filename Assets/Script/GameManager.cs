using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image hpGage;      //HPゲージの画像
    [SerializeField] private Text gameOverText; //ゲームオーバーを表示するテキスト
    [SerializeField] private Text ContinueText; //コンティニューを表示するテキスト
    [SerializeField] private AudioClip GameOverSE; //ゲームオーバーを表示するテキスト
    AudioSource audioSource;


    void Start()
    {
        //ゲーム開始時はテキストを表示させない
        gameOverText.text = "";
        ContinueText.text = "";
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //ゲージの値をHPの割合に合わせて更新する
        hpGage.fillAmount = playerHealth.hp / 10f; //"PlayerHealth"スクリプトの"hp"変数を参照している。
                                                  //PlayerのHPの最大値を10で割ることでHPの減りを実装している。

        //プレイヤーのHPが0以下になったら
        if (playerHealth.hp <= 0)
        {
            //テキストの文字を変更
            gameOverText.text = "Game Over...";
            ContinueText.text = "Push Enter to Continue";
            audioSource.PlayOneShot(GameOverSE);



            //Enterキーが押されたとき
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //シーンを読み込みなおす
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
