using System.Collections.Generic;
using UnityEngine;


namespace Benchmark
{
    public abstract class BenchmarkBase : MonoBehaviour
    {
        public List<Collider2D> Areas;
        public abstract int AgentsCount { get; }

        public abstract void NewTargetForAllAgents();
        public abstract void SpawnNAgents(int n);
        public abstract void DeleteAllAgents();
        public abstract void SetRandomPositionsForAll();

        protected Vector2 GetRandomPointInArea()
        {
            Collider2D area = Areas[Random.Range(0, Areas.Count)];
            return new Vector2(
                Random.Range(area.bounds.min.x, area.bounds.max.x),
                Random.Range(area.bounds.min.y, area.bounds.max.y)
            );
        }
    }
}