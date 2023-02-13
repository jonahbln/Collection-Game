using UnityEngine;

public class Vectors2 : MonoBehaviour
{
    Vector3 playerPosition;
    Vector3 enemyPosition;

    public GameObject player;

    public GameObject[] enemies;
    void Start()
    {
        enemyPosition = transform.position;

        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //var playerPosition = player.transform.position;


        Vector3 direction = enemyPosition - playerPosition;

        var distance = Vector3.Distance(enemyPosition, playerPosition);

        /*
        Debug.Log("Distance: " + direction.magnitude);
        Debug.Log("Distance: " + distance);

        Debug.Log("Unit vector for the direction: " + direction.normalized);
        Debug.Log("Magnitude for unit vector for the direction: " + direction.normalized.magnitude);
        */

        float dotProduct = Vector3.Dot(enemyPosition, playerPosition);
        float angle = Vector3.Angle(enemyPosition, playerPosition);

        Debug.Log("Dot Product: " + dotProduct);

        Debug.Log("Angle: " + angle);


    }

    // Update is called once per frame
    void Update()
    {
        enemyPosition = transform.position;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        float dotProduct = Vector3.Dot(enemyPosition, playerPosition);
        float angle = Vector3.Angle(enemyPosition, playerPosition);

        Debug.Log("Dot Product: " + dotProduct);

        Debug.Log("Angle: " + angle);

        Vector3 crossProduct = Vector3.Cross(enemyPosition, playerPosition);

        Debug.Log("Cross Product: " + crossProduct);
    }
}
