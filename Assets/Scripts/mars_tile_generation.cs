using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class mars_tile_generation : MonoBehaviour
{

    public int width;
    public int height;

    public int smallestPlatform;
    public int largestPlatform;
    public int maxTerrainHeight;

    public int safeZone;

    public Tile topTile;
    public Tile bottomTile;
    public Tile forwardTile;
    public Tile backwardTile;
    public Tilemap highlightMap;

    public int[] elevationMap;
    int[,] map;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        GenerateEvolutionMap();
        DrawTiles();
        //map = GenerateMap(elevationMap);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            GenerateEvolutionMap();
            DrawTiles();
        }
    }

    private void GenerateEvolutionMap() {
        elevationMap = new int[width];

        InitSafeZone();
        
        int xIndex = safeZone;
        int elevation = 0;

        //generates the elevationMap
        while(xIndex < width) {
            elevation = NewElevation(elevation);
            int platformSize = PlatformSize();
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
            }
        }
    }

    void DrawTiles() {
        highlightMap.ClearAllTiles();
        if(elevationMap.Length != 0){
            for(int x=0; x<width; x++){
                for(int y=-1; y<=elevationMap[x]; y++){
                    Vector3Int pos = new Vector3Int(x, y, 0);
                    if(y == elevationMap[x]){
                        if(x>0 && elevationMap[x] > elevationMap[x-1]){
                            highlightMap.SetTile(pos, forwardTile);
                        }
                        else if(x<width-1 && elevationMap[x] > elevationMap[x+1]){
                            highlightMap.SetTile(pos, backwardTile);
                        }
                        else{
                            highlightMap.SetTile(pos, topTile);
                        }
                    }
                    else{
                        highlightMap.SetTile(pos, bottomTile);
                    }
                }
                
            }
        }
    }


}