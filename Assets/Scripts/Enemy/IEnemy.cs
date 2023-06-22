using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    EnemyBehaviour SetOwner(Enemy E);
    EnemyBehaviour SetTarget(Model M);
    void ExecuteBehaviour();
    void OnAwake();
    void OnSleep();
}
