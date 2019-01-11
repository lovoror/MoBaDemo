﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.Networking;

public class LoadAssetBundleTest : MonoBehaviour{
    private void Start() {
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/AssetBundle/testdependc");
        Debug.Log(assetBundle);

        GameObject a = assetBundle.LoadAsset<GameObject>("Skeleton@Skin No AI");

        Debug.Log(a.name);

        GameObject.Instantiate<GameObject>(a);
    }

}

