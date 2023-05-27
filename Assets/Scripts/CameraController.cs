using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float moveSpeed = 10f;
    public float turnSpeed = 10f;

    private float lookAngle;
    private float tiltAngle;
    private const float TILT_MIN = -45f;
    private const float TILT_MAX = 45f;

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * turnSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * turnSpeed;
        lookAngle += mouseX;
        tiltAngle -= mouseY;
        tiltAngle = Mathf.Clamp(tiltAngle, TILT_MIN, TILT_MAX);

        Quaternion rotation = Quaternion.Euler(tiltAngle, lookAngle, 0f);
        transform.rotation = rotation;

        target.rotation = Quaternion.Euler(0f, lookAngle, 0f);
    }
}
