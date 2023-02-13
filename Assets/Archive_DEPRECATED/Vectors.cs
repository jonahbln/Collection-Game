using UnityEngine;

public class Vectors : MonoBehaviour
{

    //Vector3 direction = new Vector3();
    Vector3 position = new Vector3(2f, 5f, 2f);



    // Start is called before the first frame update
    void Start()
    {
        var up = Vector3.up; // (0,1,0)
        Vector3 up2 = Vector3.up;

        var down = Vector3.down;

        Debug.Log(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }

        transform.Rotate(Vector3.up * Time.deltaTime * 90f);
    }
}
