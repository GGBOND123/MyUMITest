using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyTestAndroid : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI text;

    private void Start() 
    {
        button.onClick.AddListener(OnClickButton);
    }

    private static void OnClickButton() 
    {
        Debug.LogError("点击了！！！！");

#if UNITY_ANDROID && !UNITY_EDITOR
    using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer")) 
        {
            using (AndroidJavaObject activity = jc.GetStatic<AndroidJavaObject>("currentActivity")) 
            {
                activity.Call("showMessage", "耶耶耶耶耶成功啦！！太牛啦！");
            }
        }
#endif
    }


    private void ChangeText(string data) 
    {
        text.text = data;
    }
}
