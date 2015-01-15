using UnityEngine;
using System.Collections;

public abstract class ClassAbstractBase {

    protected string message = "ClassAbstractBase";

    public ClassAbstractBase () {
        Debug.Log("ClassAbstractBaseのコンスタラクタ");
    }

    public ClassAbstractBase (string message, int num) {
        Debug.Log("ClassAbstractBaseのコンスタラクタのオーバーロード ---- " + message + " " + num);
        this.message = message;
    }

    /*
     * abstract classでのみabstractメソッドは定義できる
     */
    public abstract void Test ();

    ~ClassAbstractBase () {
        Debug.Log("ClassAbstractBaseのデストラクタ ---- " + this.message);
    }
}
