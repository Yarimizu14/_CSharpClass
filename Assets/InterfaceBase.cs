using UnityEngine;
using System.Collections;

interface InterfaceBase {

    void InterfaceTest();

    /*
     * public, privateをつけるとエラー
     */
    //public void InterfaceTest();
    //private void InterfaceTest();
}
