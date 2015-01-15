using UnityEngine;
using System;
using System.Collections;

public class Main4 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log(" ==============Generic Method Test============== ");
        var result = Ret(123);
        Debug.Log(result.GetType()); // => Int

        var result2 = Ret<double>(123);
        Debug.Log(result2.GetType()); // => Double

        Debug.Log(" ==============ClassGeneric<Type>============== ");
        ClassGeneric<ClassVirtualBase> gClass = new ClassGeneric<ClassVirtualBase>();
        gClass.CallTest();

        Debug.Log(" ==============ClassGeneric2<T, V>============== ");
        ClassGeneric2<ClassExtendVirtualBase, int> gClass2 = new ClassGeneric2<ClassExtendVirtualBase, int>();
        gClass2.CallTest();
        gClass2.SetComparableValue(3);
        if (gClass2.IsBigger(5)) {
            Debug.Log("Bigger than value");
        } else {
            Debug.Log("Smaller than value");
        }
    }

    /*
     * where句がなくても大丈夫
     */
    public static Type Ret<Type>(Type a) {
        return a;
    }

    /*
     * IComparableはInterface名 : IComparableを実装したもののみTypeにできるという制約
     */
    public static Type Bigger<Type>(Type a, Type b) where Type : IComparable {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
