using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAStarWP : MonoBehaviour
{
    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        ///g = wpManager.GetComponent<WPManager>().graph;
        currentNode = wps[0];
        agent = this.GetComponent<NavMeshAgent>();

        //Invoke("GoToRuin", 2);

        Time.timeScale = 5;
    }

    public void GoToHeli()
    {
        //g.AStar(currentNode, wps[0]);
        agent.SetDestination(wps[0].transform.position);
    }

    public void GoToRuin()
    {
        //g.AStar(currentNode, wps[6]);
        agent.SetDestination(wps[6].transform.position);
    }

    public void GoToFactory()
    {
        //g.AStar(currentNode, wps[7]);
        agent.SetDestination(wps[7].transform.position);
    }

    public void GoToCamp()
    {
        //g.AStar(currentNode, wps[1]);
        agent.SetDestination(wps[1].transform.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /*
        if(g.pathList.Count == 0 || currentWP == g.pathList.Count)
            return;

        if (Vector3.Distance(g.pathList[currentWP].getId().transform.position,
            this.transform.position) < accuracy)
        {
            currentNode = g.pathList[currentWP].getId();
            currentWP++;
        }

        if (currentWP < g.pathList.Count)
        {
            goal = g.pathList[currentWP].getId().transform;
            Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
            Vector3 direction = lookAtGoal - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
            this.transform.Translate(0, 0, speed * Time.deltaTime); 
        }
        */
    }
}
