using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AudioSourcePrefab))]
public class AudioSourcePrefabEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        base.OnInspectorGUI();

        AudioSourcePrefab singleAudioPrefab = (AudioSourcePrefab)target;
        EditorGUILayout.LabelField("(test play는 완전한 프리팹모드에서만 됨)");
        if (GUILayout.Button("Test Play"))
            singleAudioPrefab.TestPlay();
    }
}
