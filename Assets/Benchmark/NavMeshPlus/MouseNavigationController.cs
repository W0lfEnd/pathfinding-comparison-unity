using UnityEngine;
using UnityEngine.AI;

public class MouseNavigationController : MonoBehaviour
{
    public Vector3 targetPosition;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        SetTargetPosition();
        SetAgentPosition();
    }

    void SetTargetPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void SetAgentPosition()
    {
        var newPosition = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        agent.SetDestination(newPosition);
    }
}