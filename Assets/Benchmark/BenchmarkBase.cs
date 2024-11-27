using System.Collections.Generic;
using UnityEngine;


namespace Benchmark
{
    public abstract class BenchmarkBase : MonoBehaviour
    {
        public Collider2D Area;
        public abstract int AgentsCount { get; }

        public abstract void NewTargetForAllAgents();
        public abstract void SpawnNAgents(int n);
        public abstract void DeleteAllAgents();
        public abstract void SetRandomPositionsForAll();

        protected Vector2 GetRandomPointInArea()
        {
            return new Vector2(Random.Range(Area.bounds.min.x, Area.bounds.max.x),
                Random.Range(Area.bounds.min.y, Area.bounds.max.y));
        }
    }
}