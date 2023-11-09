using UnityEngine;

public class Tank : MonoBehaviour
{
  public float speed;
  public float rotateSpeed;
  public string verticalAxis;
  public string horizontalAxis;
  public KeyCode shootKey;
  public GameObject bullet;
  public Transform shootPoint;
  Rigidbody rb;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    var ver = Input.GetAxis(verticalAxis);
    rb.velocity = transform.forward * speed * ver;

    var hor = Input.GetAxis(horizontalAxis);
    transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

    if (Input.GetKeyDown(shootKey))
    {
      Instantiate(bullet, shootPoint.position, shootPoint.rotation);
    }
  }
}