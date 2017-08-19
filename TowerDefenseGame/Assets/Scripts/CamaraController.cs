using UnityEngine;

public class CamaraController : MonoBehaviour
{
    private bool doMovement = false;
    public float panSpeed = 30f;
    public float panBorderThinkness = 10f;
    public float scrollSpeed = 5f;
    private float minX = 0f;
    private float maxX = 75f;
    private float minY = 10f;
    private float maxY = 80f;
    private float minZ = -15f;
    private float maxZ = 65f;

    // Update is called once per frame
    void Update ()
    {
        if (GameManager.GameIsOver || PauseMenu.GameIsPaused)
        {
            this.enabled = false;
            return;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            doMovement = !doMovement;
        }

        if (!doMovement)
            return;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThinkness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThinkness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThinkness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThinkness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        transform.position = pos;
    }
}
