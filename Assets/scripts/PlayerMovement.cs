using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3f;
    public float horizontalSpeed = 9f;
    public float rightLimit = 7f;
    public float leftLimit = -7f;

    void Update()
    {
        // Move player forward
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // Move left when pressing A or Left Arrow
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }

        // Move right when pressing D or Right Arrow
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }
    }
}
