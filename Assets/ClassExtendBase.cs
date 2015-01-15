using UnityEngine;
using System.Collections;

public class ClassExtendBase : ClassBase {

    public ClassExtendBase() {
        Debug.Log("ClassExtendBaseのコンスタラクタ ---- ClassBaseコンスタラクタの後に呼び出されます");
    }

    public ClassExtendBase(string message) : base(message, 0) {
        Debug.Log("ClassExtendBaseのコンスタラクタ ---- " + message);
    }

    /*
     * 継承元のメソッドがvirtual or abstractではない場合、overrideをつけてオーバーライドできない
     */
    //public override void Test () {
    public new void Test () {
        Debug.Log("ClassExtendBase.Test Method Called");
    }
}
