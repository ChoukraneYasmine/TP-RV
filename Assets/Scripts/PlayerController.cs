using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f; // Vitesse de déplacement
    public float turnSpeed = 50f; // Vitesse de rotation
    private float horizontalInput; // Entrée clavier pour gauche/droite
    private float forwardInput; // Entrée clavier pour avancer/reculer

    void Update()
    {
        // Récupérer les entrées clavier
        horizontalInput = Input.GetAxis("Horizontal"); // Flèches gauche/droite ou Q/D
        forwardInput = Input.GetAxis("Vertical"); // Flèches haut/bas ou Z/S

        // Déplacement du véhicule
        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
        
        // Rotation du véhicule
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) // Si le véhicule touche un obstacle
        {
            FindObjectOfType<ScoreManager>().AddScore(10); // Ajoute 10 points
        }
        else if (collision.gameObject.CompareTag("ObstacleType2")) // Si le véhicule touche un obstacle Type 2
        {
            Destroy(collision.gameObject); // L'obstacle disparaît
            FindObjectOfType<ScoreManager>().AddScore(20); // Ajoute 20 points
        }
        else if (collision.gameObject.CompareTag("ObstacleType3")) // Si le véhicule touche un obstacle Type 3
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500); // L'obstacle s'envole
            FindObjectOfType<ScoreManager>().AddScore(30); // Ajoute 30 points
        }
    }
}
