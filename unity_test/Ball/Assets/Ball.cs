using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{  
    // 클래스는 코드를 모아놓는 기본 단위

    int  count = 1;
    // Start is called before the first frame update
    void Start() {
        // 게임이 시작 될때 실행
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update() {
        // 매 프레임 마다 실행 (다양한 로직 구현 가능)
        Debug.Log("Update" + count);
        count += 1;
    }
}
