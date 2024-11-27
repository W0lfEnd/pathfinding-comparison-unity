namespace Benchmark.Aoiti
{
    public class AotiBenchmark : Benchmark<MovementController2D>
    {
        public MovementController2D AgentPrefab;

        protected override MovementController2D SpawnAgent()
        {
            MovementController2D agent = Instantiate(AgentPrefab);
            agent.transform.position = GetRandomPointInArea();
            return agent;
        }

        protected override void SetRandomTarget(MovementController2D agent)
        {
            agent.GetMoveCommand(GetRandomPointInArea());
        }
    }
}