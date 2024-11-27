using System.Collections;
using UnityEngine;

public abstract class BenchmarkBase : MonoBehaviour
{
   protected float StartTime;
   protected float SpendTime;

   public abstract void Init();
   protected abstract IEnumerator OnStart();
   protected abstract void OnStop();
   
   // public 
}
