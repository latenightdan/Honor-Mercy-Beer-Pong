
using UnityEngine;
using UnityEngine.InputSystem;

public class firstPersonInputSystem : MonoBehaviour
{

    private static firstPersonInputSystem _instance;

    public static firstPersonInputSystem Instance
    {
        get
        {
            return _instance;
        }

    }


    private NewControls controls;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        controls = new NewControls();
    }


    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }



    public Vector2 GetPlayerMovement()
    {
        return controls.Playa.Movement.ReadValue<Vector2>();
    }
    public Vector2 GetStick()
    {
        return controls.Playa.Look.ReadValue<Vector2>();
       

    }
    public bool PlayerJump()
    {
        return controls.Playa.Jump.triggered;

    }
    public bool Honor()
    {
        return controls.Playa.HONOR.triggered;

    }
    public bool Mercy()
    {
        return controls.Playa.MERCY.triggered;

    }
    public bool Narc()
    {
        return controls.Playa.TakeNarc.triggered;

    }

}
