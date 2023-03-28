
using UnityEngine;
using UnityEngine.InputSystem;

public class VisablityScript : MonoBehaviour
{

    public InputAction button = new InputAction(type: InputActionType.Button);
    private bool state = true;

    // Start is called before the first frame update
    void Start()
    {
        button.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (button.WasPressedThisFrame())
        {
            state = !state;
            GetComponent<SpriteRenderer>().enabled = state;
        }
    }
}
