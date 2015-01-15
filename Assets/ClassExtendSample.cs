using UnityEngine;
using System.Collections;

public class ClassExtendSample : ClassBasic {

    public ClassExtendSample() {
        Debug.Log("ClassExtendSampleのコンスタラクタ ---- ClassBasicコンスタラクタの後に呼び出されます");
    }

    public ClassExtendSample(string message) : base(message, 0) {
        Debug.Log("ClassExtendSampleのコンスタラクタ ---- " + message);
    }
}
