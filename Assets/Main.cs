using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    ClassBase a;

    // Use this for initialization
    void Start () {
        Debug.Log(" ==============ClassBase============== ");
        a = new ClassBase();
        ClassBase b = new ClassBase("ClassBase's Argument", 1);

        Debug.Log(" ==============ClassExtendBase============== ");
        ClassExtendBase c = new ClassExtendBase();
        ClassExtendBase d = new ClassExtendBase("ClassExtendBase's Argument");

        Debug.Log(" ================================== ");
    }

    // Update is called once per frame
    void Update () {
        /*
         * ここでaのデストラクタが呼ばれる
         */
        a = null;
    }
}

