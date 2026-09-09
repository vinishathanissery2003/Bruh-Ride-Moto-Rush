using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    [Header("Camera")]
    public float smoothspeed = 5f;
    public float x0ffset = 3f;

    private float fixedY;

    private void Start()
    {
        fixedY = transform.position.y;
    }

    private void LateUpdate()
    {
        if (target == null)
            return;

        float targetX = target.position.x + x0ffset;

        float newX = Mathf.Lerp(
            transform.position.x,
            targetX,
            smoothspeed * Time.deltaTime
        );

        transform.position = new Vector3(
            newX,
            fixedY,
            transform.position.z
            );
    }
}
