using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : BaseState
{
     public override void Enter()
     {
        
         enemy.animator.SetBool("move", false);
         
         enemy.animator.SetBool("isShooting", false);
         enemy.animator.SetBool("isDead", true);
        enemy.Agent.ResetPath(); // 如果需要，停止導航
     }
      public override void Perform()
      {

      }
       public override void Exit()
       {
            enemy.animator.SetBool("isDead", false);
       }
}
