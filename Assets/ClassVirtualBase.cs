using UnityEngine;
using System.Collections;

public class ClassVirtualBase {

    protected string message = "ClassVirtualBase";

    public ClassVirtualBase () {
        Debug.Log("ClassVirtualBaseのコンスタラクタ");
    }

    public ClassVirtualBase (string message, int num) {
        Debug.Log("ClassVirtualBaseのコンスタラクタのオーバーロード ---- " + message + " " + num);
        this.message = message;
    }

    public virtual void Test () {
        Debug.Log("ClassVirtualBase.Test Method Called");
    }

    public virtual void Test2 () {
        Debug.Log("ClassVirtualBase.Test2 Method Called");
    }

    ~ClassVirtualBase () {
        Debug.Log("ClassVirtualBaseのデストラクタ ---- " + this.message);
    }
}
