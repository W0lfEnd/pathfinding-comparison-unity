using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Benchmark
{
   public abstract class Benchmark<TAgent> : BenchmarkBase
      where TAgent : Behaviour
   {
      public List<TAgent> Agents;
      public override int AgentsCount => Agents.Count;

      protected abstract TAgent SpawnAgent();
      protected abstract void SetRandomTarget(TAgent agent);
      

      public override void NewTargetForAllAgents()
      {
         foreach (TAgent agent in Agents)
            SetRandomTarget(agent);
      }

      public override void SpawnNAgents(int n)
      {
         Agents ??= new List<TAgent>(n);
         for (int i = 0; i < n; i++)
         {
            TAgent agent = SpawnAgent();
            Agents.Add(agent);
            SetRandomTarget(agent);
         }
      }

      public override void DeleteAllAgents()
      {
         foreach (TAgent agent in Agents)
         {
            Destroy(agent.gameObject);
         }

         Agents.Clear();
      }
      
      public override void SetRandomPositionsForAll()
      {
         foreach (TAgent agent in Agents)
         {
            agent.transform.position = GetRandomPointInArea();
         }
      }
   }
}
