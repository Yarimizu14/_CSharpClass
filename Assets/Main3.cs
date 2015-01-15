using UnityEngine;
using System.Collections;

public class Main3 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log(" ==============ClassAbstractBase============== ");
        /*
         * 抽象クラスなのでインスタンス化できない
         */
        //ClassAbstractBase a = new ClassAbstractBase();
        ClassExtendAbstractBase a = new ClassExtendAbstractBase();
        a.Test();

        /*
         * 抽象クラスでも静的な型としては指定できる
         */
        ClassAbstractBase b = new ClassExtendAbstractBase();
        b.Test();

        Debug.Log(" ==============InterfaceBase============== ");
        ClassInterfaceImplement c = new ClassInterfaceImplement();
        c.InterfaceTest();
    }

    // Update is called once per frame
    //
    void Update () {
    }
}
