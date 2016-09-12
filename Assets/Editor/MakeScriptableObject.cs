using UnityEngine;
using UnityEditor;
using System.Collections;

public class MakeScriptableObject
{
    [MenuItem("Assets/Create/Game Values")]
    public static void CreateMyAsset()
    {
        GameValues asset = ScriptableObject.CreateInstance<GameValues>();

        AssetDatabase.CreateAsset(asset, "Assets/GameValues.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;

    }


}
