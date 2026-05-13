using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeAnim : MonoBehaviour
{
    [Header("Anim")]
    public Animator anim;

    [Header("Trigger")]
    public string key1_DAB;

    [Header("Bool")]
    public string key0_IDLE;
    public string key2_Thinking;
    public string key3_Thinking2;
    public string key4_Crouch;
    public string key5_Crouch2;
    public string key6_Crouch3;
    public string key7_Crouch4;

    private Keyboard keyboard;

    void Update()
    {
        keyboard = Keyboard.current;

        if (keyboard == null) return;

        // IDLE
        if (keyboard.digit0Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key0_IDLE, true);
        }

        if (keyboard.digit1Key.wasPressedThisFrame)
        {
            anim.SetTrigger(key1_DAB);
        }

        if (keyboard.digit2Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key2_Thinking, true);
        }

        if (keyboard.digit3Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key3_Thinking2, true);
        }

        if (keyboard.digit4Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key4_Crouch, true);
        }

        if (keyboard.digit5Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key5_Crouch2, true);
        }

        if (keyboard.digit6Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key6_Crouch3, true);
        }

        if (keyboard.digit7Key.wasPressedThisFrame)
        {
            TurnAllBoolsOff();
            anim.SetBool(key7_Crouch4, true);
        }
    }

    void TurnAllBoolsOff()
    {
        anim.SetBool(key0_IDLE, false);
        anim.SetBool(key2_Thinking, false);
        anim.SetBool(key3_Thinking2, false);
        anim.SetBool(key4_Crouch, false);
        anim.SetBool(key5_Crouch2, false);
        anim.SetBool(key6_Crouch3, false);
        anim.SetBool(key7_Crouch4, false);
    }
}