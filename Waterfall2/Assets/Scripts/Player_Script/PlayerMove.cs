using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
 //Geschwindigkeit des Spielers
    public float playerSpeed = 0.2f;

    private Vector3 startPos;
    private Vector3 currentPlayerPos;
    private int hits = 0;
    private int row = 3;

    void Start()
    {
        startPos = this.transform.position;
        currentPlayerPos = startPos;
    }

    private void Update()
    {
        LeftRightInput();
        MovePlayer();
    }

 /*
 Spielweise Swipen (touch input) (rechts/links)
 gleichzeitig einschränungen auf die rows +/- ,
 dass der Player nicht über den Fluss hinaus fährt
 */
    void LeftRightInput()
    {
        if (SwipeManager.swipeLeft || Input.GetKeyDown("left"))
        {
            if (row > 1)
            {
                currentPlayerPos += new Vector3(2.2f, 0f, 0f);
                row--;
            }
        }
        if (SwipeManager.swipeRight || Input.GetKeyDown("right"))
        {
            if (row < 5)
            {
                currentPlayerPos += new Vector3(-2.2f, 0f, 0f);
                row++;
            }
        }
    }

 //Bewegung des Spielers (rechts/links)
    void MovePlayer()
    {
        this.transform.position = Vector3.Lerp(
                this.transform.position,
                currentPlayerPos,
                Time.fixedDeltaTime * playerSpeed);
    }

 //Player wird getroffen und nach hinten versetzt - nach 3 hits GameOver.Scene wird geladen!
    public void ObstacleHit()
    {
        hits++;
        currentPlayerPos += new Vector3(0f, 0f, 5f);
        
        if(hits == 3)
        {
            SceneManager.LoadScene("UI_GameOver");
        }
    }
}
