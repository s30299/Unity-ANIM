using UnityEngine;

public class MainMenuController : MonoBehaviour

{

    [SerializeField] CloudController cc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        cc.SceneTransition(5f, () =>
        {
            Debug.Log("Scene has been changed");
        });
    }
}
