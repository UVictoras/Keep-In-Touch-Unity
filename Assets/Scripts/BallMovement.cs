using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private float move;

    public GameObject leftTriangle, rightTriangle;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        gameObject.transform.localPosition = new Vector2(Mathf.Clamp(gameObject.transform.localPosition.x, -18, 18),gameObject.transform.position.y);

        float Horizontal = Input.GetAxisRaw("Horizontal");
        move = Horizontal;

        body.velocity = new Vector2(move * this.speed, body.velocity.y);

        if(move == 0 && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.M))
            StartCoroutine(Wait());
        if(move != 0)
            StopCoroutine(Wait());

        if (leftTriangle.GetComponent<TriangleTrigger>().collide == true || rightTriangle.GetComponent<TriangleTrigger>().collide == true)
            StartCoroutine(InTriangle());
        if (leftTriangle.GetComponent<TriangleTrigger>().collide == false || rightTriangle.GetComponent<TriangleTrigger>().collide == false)
            StopCoroutine(InTriangle());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        if (move == 0 && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.M))
            SceneManager.LoadScene("LooseScreen",LoadSceneMode.Single);
    }

    IEnumerator InTriangle()
    {
        yield return new WaitForSeconds(3);
        if (leftTriangle.GetComponent<TriangleTrigger>().collide == true || rightTriangle.GetComponent<TriangleTrigger>().collide == true)
            SceneManager.LoadScene("LooseScreen",LoadSceneMode.Single);
    }
}
