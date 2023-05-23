using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private float move;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        move = Horizontal;

        if (body.position.x > -18 && body.position.x < 18)
            body.velocity = new Vector2(move * this.speed, body.velocity.y);

        if(move == 0 && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.M))
            StartCoroutine(Wait());
        if(move != 0)
            StopAllCoroutines();

        if ((body.position.x >= -18 && body.position.x <= -17) || (body.position.x >= 17 && body.position.x <= 18))
            StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        if (move == 0 && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("LooseScreen",LoadSceneMode.Single);
        }
        if ((body.position.x >= -18 && body.position.x <= -17) || (body.position.x >= 17 && body.position.x <= 18))
        {
            SceneManager.LoadScene("LooseScreen",LoadSceneMode.Single);
        }
    }
}
