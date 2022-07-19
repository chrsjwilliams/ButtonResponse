using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MonoTweener))]
public class MonoTweenPlayer : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        //MonoTweener tween = (MonoTweener)target;
        //if(GUILayout.Button("Play Tween"))
        //{
        //    tween.Play();
        //}
    }
}
