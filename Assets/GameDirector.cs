using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
   public Text kyoriLabel; //距離を表示するUI-Textオブジェクト
    int kyori;             //距離を保持する変数

    public Image timeGauge;//タイムゲージを表示するUI

    public static float lastTime;　　　　//残り時間を保持する変数

    // Start is called before the first frame update
    void Start()
    {
        kyori = 0;
        lastTime = 100f;//残り時間100秒
    }

    // Update is called once per frame
    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //残り時間がゼロになったらリロード
        if (lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        //進んだ距離を表示
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}
