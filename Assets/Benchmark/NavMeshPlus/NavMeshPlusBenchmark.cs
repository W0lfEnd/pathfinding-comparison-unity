using UnityEngine.AI;


namespace Benchmark.NavMeshPlus
{
    public class NavMeshPlusBenchmark : Benchmark<NavMeshAgent>
    {
        public NavMeshAgent AgentPrefab;

        protected override NavMeshAgent SpawnAgent()
        {
            NavMeshAgent agent = Instantiate(AgentPrefab);
            agent.updateRotation = false;
            agent.updateUpAxis = false;
            agent.transform.position = GetRandomPointInArea();
            return agent;
        }

        protected override void SetRandomTarget(NavMeshAgent agent)
        {
            agent.SetDestination(GetRandomPointInArea());
        }
    }
}