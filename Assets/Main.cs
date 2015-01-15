using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    ClassBasic a;

    // Use this for initialization
    void Start () {
        Debug.Log(" ==============ClassBasic============== ");
        a = new ClassBasic();
        ClassBasic b = new ClassBasic("ClassBasic's Argument", 1);

        Debug.Log(" ==============ClassExtendSample============== ");
        ClassExtendSample c = new ClassExtendSample();
        ClassExtendSample d = new ClassExtendSample("ClassExtendSample's Argument");

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

