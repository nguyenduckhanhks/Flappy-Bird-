using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEndGame;
    float score = 0;
    public Text txtPoint;
    public GameObject pnEndGame;
    public Text txtEndGame;
    public Button btnRestart;
    public Sprite btnIdleImg;
    public Sprite btnHoverImg;
    public Sprite btnEnterImg;
    void Start()
    {
        Time.timeScale = 0;
        pnEndGame.SetActive(false);
        isEndGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEndGame){
            if(Input.GetMouseButtonDown(0)){
                SceneManager.LoadScene(0);
            }
        }
        else{
            if(Input.GetMouseButtonDown(0)){
                Time.timeScale = 1;
            }
        }
    }

    public void restart(){
        SceneManager.LoadScene(0);
    }

    public void getPoint(){
        score++;
        txtPoint.text = "Point: "+score.ToString();
    }

    public void btnRestartHover(){
        btnRestart.GetComponent<Image>().sprite = btnHoverImg;
    }

    public void btnRestartEnter(){
        btnRestart.GetComponent<Image>().sprite = btnEnterImg;
    }

    public void btnRestartExit(){
        btnRestart.GetComponent<Image>().sprite = btnIdleImg;
    }
    public void endGame(){
        pnEndGame.SetActive(true);
        txtEndGame.text = "Your Point: "+score.ToString();
        Time.timeScale = 0;
        isEndGame = true;
    }
}
