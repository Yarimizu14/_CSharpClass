using UnityEngine;
using System.Collections;

public class ClassExtendVirtualBase : ClassVirtualBase {

    public ClassExtendVirtualBase() {
        Debug.Log("ClassExtendVirtualBaseのコンスタラクタ ---- ClassBaseコンスタラクタの後に呼び出されます");
    }

    public ClassExtendVirtualBase(string message) : base(message, 0) {
        Debug.Log("ClassExtendVirtualBaseのコンスタラクタ ---- " + message);
    }

    /*
     * ポリモーフィズムを使える
     */
    public override void Test () {
        Debug.Log("ClassExtendVirtualBase.Test Method Called");
    }

    /*
     * ポリモーフィズムを使えない
     */
    public new void Test2 () {
        Debug.Log("ClassExtendVirtualBase.Test2 Method Called");
    }
}
