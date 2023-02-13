using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    // VARS
    public float rotationAmount = 5.0f;
    //private int someInt = 1;

   // string someString;
    //bool someBool = true;

    public GameObject someObject;
    public Transform someTransform;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, rotationAmount, 0);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }

        // transform.Rotate(Vector3.up * 90f);
    }

    private void OnMouseDown()
    {
        //Destroy(this.gameObject, 3);
        gameObject.SetActive(false);
        
    }
}
