using Pathfinding;
using UnityEngine;


namespace Benchmark.AStarProject
{
    public class AStarProjectBenchmark : Benchmark<AIBase>
    {
        public AIBase AgentPrefab;

        protected override AIBase SpawnAgent()
        {
            AIBase agent = Instantiate(AgentPrefab);
            agent.transform.position = GetRandomPointInArea();
            return agent;
        }

        protected override void SetRandomTarget(AIBase agent)
        {
            var destinationSetter = agent.GetComponent<AIDestinationSetter>();
            Transform tr;
            if(destinationSetter.target)
            {
                tr = destinationSetter.target;
            }
            else
            {
                tr = new GameObject("Target").transform;
                destinationSetter.target = tr;
            }
            tr.position = GetRandomPointInArea();
            destinationSetter.target = tr;
        }
    }
}