using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class UnityToast : MonoBehaviour
{
    public static void InitBotEmojiView(){
#if UNITY_IOS && !UNITY_EDITOR
        _initBotEmojiView();
#endif
    }
    
    public static void ShowBotToast(string text, float duration){
#if UNITY_IOS && !UNITY_EDITOR
        _showBotToast(text, duration);
#endif
    }
    
    public static void ShowTopToast(string text, float duration = 5.0f){
#if UNITY_IOS && !UNITY_EDITOR
        _showTopToast(text, duration);
#endif
    }
    
    
    public static void ShowBottomToast(string text, float duration = 5.0f){
#if UNITY_IOS && !UNITY_EDITOR
        _showBottomToast(text, duration);
#endif
    }
    
    public static void ShowAlert(string title, string message){
#if UNITY_IOS && !UNITY_EDITOR
        _showAlert(title, message);
#endif
    }

#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _initBotEmojiView();
#endif
    
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _showBotToast(string text, float duration);
#endif
    
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _showTopToast(string text, float duration);
#endif
    
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _showBottomToast(string text, float duration);
#endif
    
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void _showAlert(string title, string message);
#endif
}
