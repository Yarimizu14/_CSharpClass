using UnityEngine;
using System.Collections;

public class Main2 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log(" ==============ClassBase============== ");
        /*
         * 静的な方 : ClassBase, 動的な型 : ClassBase
         */
        ClassBase a = new ClassBase();
        a.Test();

        /*
         * 静的な方 : ClassBase, 動的な型 : ClassExtendBase
         */
        ClassBase b = new ClassExtendBase();
        b.Test(); // 静的な型(ClassBase)のTestメソッドが呼び出される

        Debug.Log(" ==============ClassVirtualBase============== ");
        /*
         * 静的な方 : ClassVirtualBase, 動的な型 : ClassVirtualBase
         */
        ClassVirtualBase c = new ClassVirtualBase();
        c.Test();

        /*
         * 静的な方 : ClassVirtualBase, 動的な型 : ClassExtendVirtualBase
         */
        ClassVirtualBase d = new ClassExtendVirtualBase();
        d.Test();   // 動的な型(ClassExtendVirtualBase)のTestメソッドが呼び出される : overrideを付けてオーバーライド
        d.Test2();  // 静的な型(ClassVirtualBase)のTest2メソッドが呼び出される : newを付けてオーバーライド
    }

    // Update is called once per frame
    void Update () {
    }
}
