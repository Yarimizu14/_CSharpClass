using UnityEngine;
using System.Collections;

public class ClassInterfaceImplement : InterfaceBase {

    protected string message = "ClassInterfaceImplement";

    public ClassInterfaceImplement () {
        Debug.Log("ClassInterfaceImplementのコンスタラクタ");
    }

    public ClassInterfaceImplement (string message, int num) {
        Debug.Log("ClassInterfaceImplementのコンスタラクタのオーバーロード ---- " + message + " " + num);
        this.message = message;
    }

    public void Test () {
        Debug.Log("ClassInterfaceImplement.Test Method Called");
    }

    public void InterfaceTest() {
        Debug.Log("ClassInterfaceImplement.InterfaceTest Method Called");
    }

    ~ClassInterfaceImplement () {
        Debug.Log("ClassInterfaceImplementのデストラクタ ---- " + this.message);
    }
}
