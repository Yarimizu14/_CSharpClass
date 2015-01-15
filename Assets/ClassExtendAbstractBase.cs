using UnityEngine;
using System.Collections;

public class ClassExtendAbstractBase : ClassAbstractBase {

    /*
     * 抽象メソッドを実装
     * newを付けてオーバーライドできない
     */
    //public new void Test () {
    public override void Test () {
        Debug.Log("ClassExtendAbstractBase.Test Method Called");
    }
}
