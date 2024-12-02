using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Tmr {
    public class TimerDysplayScript : MonoBehaviour
    {
        public static bool gameOver = false;
        public TextMeshProUGUI resumeMsg;

        public TextMeshProUGUI timerText; 
        private float timer = 0f;

        void Start()
        {
            resumeMsg.gameObject.SetActive(false);
        }

        void Update()
        {
            if (!gameOver) {
                timer += Time.deltaTime;
            } else {
                resumeMsg.gameObject.SetActive(true);
                if (Input.GetKey(KeyCode.Space)) {
                    SceneManager.LoadScene("Default");
                    gameOver = false;
                }
            }
            
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        
    }
}
