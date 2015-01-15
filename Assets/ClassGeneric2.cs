using UnityEngine;
using System;
using System.Collections;

/*
 * Where句を二つ書く事も可能
 */
public class ClassGeneric2<T, V>
    where T : ClassVirtualBase, new()
    where V : IComparable
{
    /*
     * where句のnew()でパラメータなしインスタン化できるオブジェクトのみチェックし、インスタンス化可能
     * パラメータを渡してインスタンス化する場合はファクトリーパターンが必要？
     * http://stackoverflow.com/questions/731452/create-instance-of-generic-type
     */
    T Component = new T();
    V ComparableValue;

    public ClassGeneric2 () {
    }

    public void CallTest () {
        Debug.Log("Call Test method from ClassGeneric2<Type>");
        Component.Test();
    }

    /*
     * V型の変数をセットする
     */
    public void SetComparableValue(V val) {
        ComparableValue = val;
    }

    /*
     * V型の引数とV型のメンバComparableValueを比較する
     */
    public bool IsBigger (V val) {
        return ComparableValue.CompareTo(val) < 0;
    }

}

