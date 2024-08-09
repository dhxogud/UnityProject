using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager s_instance;
    public static GameManager Instance { get { return s_instance; } }

    private void Start() {
        Init();
    }
    static void Init() {
        if (s_instance == null) {
            GameObject go = GameObject.Find("@GameManager");
            if (go == null) {
                go = new GameObject {name = "@GameManager"};
                go.AddComponent<GameManager>();
            } 
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<GameManager>();
        }
    }
}
