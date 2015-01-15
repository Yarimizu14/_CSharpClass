using UnityEngine;
using System.Collections;

public class ClassBase {

    protected string message = "ClassBase";

    public ClassBase () {
        Debug.Log("ClassBaseのコンスタラクタ");
    }

    public ClassBase (string message, int num) {
        Debug.Log("ClassBaseのコンスタラクタのオーバーロード ---- " + message + " " + num);
        this.message = message;
    }

    public void Test () {
        Debug.Log("ClassBase.Test Method Called");
    }

    ~ClassBase () {
        Debug.Log("ClassBaseのデストラクタ ---- " + this.message);
    }
}

