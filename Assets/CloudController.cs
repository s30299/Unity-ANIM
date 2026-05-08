using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;


public class CloudController : MonoBehaviour
{
    [SerializeField]  Image cloud_L, cloud_R;
     public void SceneTransition(float time, Action OnObscured=null)
    {
        Debug.Log("Scene 1");
        OnObscured?.Invoke();
        StartCoroutine(FadeOut(cloud_L,115f,1f,OnObscured));
        StartCoroutine(FadeOut(cloud_R,-115f,1f,OnObscured));
    }


    public IEnumerator FadeOut(Image cloud,float targetX, float duration , Action onFadeIn = null)
    {
        float timePassed = 0f;
        var startX = cloud.transform.localPosition.x;
        float newX = 0f;
        while (timePassed < duration) {
            timePassed += Time.deltaTime;
            newX = Mathf.Lerp(startX, targetX, timePassed / duration);
            cloud.transform.localPosition = new Vector3(newX, cloud.transform.localPosition.y, cloud.transform.localPosition.z);
            yield return new WaitForEndOfFrame();
    }
        cloud.transform.localPosition = new Vector3(targetX, cloud.transform.localPosition.y, cloud.transform.localPosition.z);
        onFadeIn?.Invoke();
    }
}
