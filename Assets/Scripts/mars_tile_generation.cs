using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mars_tile_generation : MonoBehaviour
{

    public int width;
    public int height;

    public int smallestPlatform;
    public int largestPlatform;
    public int maxTerrainHeight;

    public int safeZone;

    public int[] elevationMap;
    int[,] map;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        GenerateEvolutionMap();
        //map = GenerateMap(elevationMap);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            GenerateEvolutionMap();
        }
    }

    private void GenerateEvolutionMap() {
        elevationMap = new int[width];

        //smallestPlatform = 3;
        //largestPlatform = 7;

        Debug.Log("int gen");
        //init safe zone.
        InitSafeZone();
        Debug.Log("int safeZone");
        
        int xIndex = safeZone;
        int elevation = 0;

        //generates the elevationMap
        Debug.Log("While");
        while(xIndex < width) {
            elevation = NewElevation(elevation);
            Debug.Log("NewElevation");
            Debug.Log(elevation);
            int platformSize = PlatformSize();
            Debug.Log("PlatformSize");
            Debug.Log(platformSize);
            SetEvelutionMap(xIndex, platformSize, elevation);
            xIndex+=platformSize;
        }
    }

    private void InitSafeZone() {
        for(int i=0; i<safeZone; i++)
        {
            elevationMap[i] = 0;
        }
    }

    private int NewElevation(int elevation) {
        int newEvelution = Random.Range(-1, 2) + elevation;

        if(newEvelution > maxTerrainHeight && newEvelution > height){
            newEvelution -= 1;
        }
        if(newEvelution < 0){
            newEvelution += 1;
        }

        return newEvelution;
    }

    private int PlatformSize() {
        return Random.Range(smallestPlatform, largestPlatform+1);
    }

    private void SetEvelutionMap(int xIndex, int platformSize, int elevation){
        for(int x = 0; x < platformSize; x++){
            if(xIndex < width-1)
            {
                elevationMap[xIndex] = elevation;
                xIndex++;
                Debug.Log("SetMap");
                Debug.Log(elevation);
                Debug.Log(elevationMap[xIndex]);
            }
        }
    }

    void OnDrawGizmos() {
        if(elevationMap.Length != 0){
            
            for(int x=0; x<width-1; x++){
                for(int y=-5; y<=elevationMap[x]; y++){
                    Vector3 pos = new Vector3(x + .5f, y +.5f, 0);
                    Gizmos.color = Color.grey;
                    if(y == elevationMap[x]){
                        Gizmos.color = Color.red;
                    }
                    Gizmos.DrawCube(pos, Vector3.one);
                }
                
            }
        }
    }


}