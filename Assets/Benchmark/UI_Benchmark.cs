using System;
using Benchmark;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI_Benchmark : MonoBehaviour
{
    public BenchmarkBase benchmark;

    public TextMeshProUGUI txtAgentsCount;
    public Button BtnSpawn10;
    public Button BtnSpawn100;
    public Button BtnNewTarget;
    public Button BtnDeleteAll;
    public Button BtnRandomPositions;
    
    void Start()
    {
        BtnSpawn10.onClick.AddListener(SpawnAgents10);
        BtnSpawn100.onClick.AddListener(SpawnAgents100);
        BtnNewTarget.onClick.AddListener(NewTargetForAllAgents);
        BtnDeleteAll.onClick.AddListener(DeleteAllAgents);
        BtnRandomPositions.onClick.AddListener(RandomPositions);
    }

    private void Update()
    {
        txtAgentsCount.text = "Agents: " + benchmark.AgentsCount;
    }

    void SpawnAgents10()
    {
        benchmark.SpawnNAgents(10);
    }

    void SpawnAgents100()
    {
        benchmark.SpawnNAgents(100);
    }
    
    void NewTargetForAllAgents()
    {
        benchmark.NewTargetForAllAgents();
    }
    
    void DeleteAllAgents()
    {
        benchmark.DeleteAllAgents();
    }
    
    void RandomPositions()
    {
        benchmark.SetRandomPositionsForAll();
    }
}
