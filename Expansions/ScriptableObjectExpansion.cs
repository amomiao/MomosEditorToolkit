using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Momos.EditorToolkit.Expansions
{
    public static class ScriptableObjectExpansion
    {
        public static void SaveInAssetDatabase(this ScriptableObject asset)
        {
            EditorUtility.SetDirty(asset);
            AssetDatabase.SaveAssetIfDirty(asset);
        }
    }
}