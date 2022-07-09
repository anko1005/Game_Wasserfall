using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    //Geschwindigkeit des Spielers
    public float playerSpeed = 8f;

    private Vector3 startPos;
    private Vector3 currentPlayerPos;
    private int hits = 0;

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

    //Spielweise Swipen (touch input) (rechts/links)
    void LeftRightInput()
    {
        if (SwipeManager.swipeLeft || Input.GetKeyDown("left"))
        {
            currentPlayerPos += new Vector3(2.2f, 0f, 0f);
        }
        if (SwipeManager.swipeRight || Input.GetKeyDown("right"))
        {
            currentPlayerPos += new Vector3(-2.2f, 0f, 0f);
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

    //Player wird getroffen und nach hinten versetzt - nach 3 hits GameOver!
    public void ObstacleHit()
    {
        hits++;
        currentPlayerPos += new Vector3(0f, 0f, 5f);

        if (hits == 3)
        {
            SceneManager.LoadScene("UI_GameOver");
        }
    }
}
