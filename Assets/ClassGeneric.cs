using UnityEngine;
using System.Collections;

/*
 * ClassVirtualBaseを継承し、かつ引数なしでインスタンス化できるもののみType指定できるように
 */
public class ClassGeneric<Type> where Type : ClassVirtualBase, new() {

    /*
     * where句のnew()でパラメータなしインスタン化できるオブジェクトのみチェックし、インスタンス化可能
     * パラメータを渡してインスタンス化する場合はファクトリーパターンが必要？
     * http://stackoverflow.com/questions/731452/create-instance-of-generic-type
     */
    Type Component = new Type();

    public ClassGeneric () {
    }

    public void CallTest () {
        Debug.Log("Call Test method from ClassGeneric<Type>");
        Component.Test();
    }
}

