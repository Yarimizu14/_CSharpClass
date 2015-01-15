using UnityEngine;
using System.Collections;

public class ClassBasic {

    protected string message = "ClassBasic";

    public ClassBasic () {
        Debug.Log("ClassBasicのコンスタラクタ");
    }

    public ClassBasic (string message, int num) {
        Debug.Log("ClassBasicのコンスタラクタのオーバーロード ---- " + message + " " + num);
        this.message = message;
    }

    ~ClassBasic () {
        Debug.Log("ClassBasicのデストラクタ ---- " + this.message);
    }
}

