﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManagerControl : MonoBehaviour{

    public enum ItemType { Apple,Banana,Cherry}


    private List<EggControl> eggs;
    private List<PickUpItemControl> items;
    private List<NPCControl> enemies;
    private List<PenguinControl> player;
    private int whatDestroyed;
    /*private int currentEnemies;
    private int currentItems;
    private int players;
    private int currentEggs;*/


    WorldControl theWorld;

    public Transform itemClone;
    //public int EggSpawn()

    //{
    //    //Spawn Egg

    //    eggs.Add(egg);
    //}

    public void EnemySpawn(NPCControl enemy)
    {
        //Spawn Enemy

        enemies.Add(enemy);
    }

    public void ItemSpawn(PickUpItemControl item)
    {


        Vector3 positionForNewItem = theWorld.positionForItem();

        Transform newbie = Instantiate(itemClone, positionForNewItem, Quaternion.identity);
        PickUpItemControl itemControl = newbie.GetComponent<PickUpItemControl>();
        itemControl.YouAre(ItemType.Apple, 500, 30);
        items.Add(itemControl);


    }


    public void PlayerSpawn(PenguinControl player)

    {
        //spawn Player

        this.player.Add(player);


    }
  


    /* public int AddScore(char item, int currentScore)

    {

        int scoreToAdd;

        switch(whatDestroyed)
        {
            case '1':
                {
                    scoreToAdd = 100;

                    break;
                }

            case '2':
                {
                    scoreToAdd = 250;

                    break;
                }

            default:
                {
                    scoreToAdd = 0;

                    break;
                }
        }

        score += scoreToAdd;

        /*List<ItemType> myList = new List<ItemType>();


        foreach (ItemType i in myList)
            if (i== currentlyActiveType) 

        switch(item)
        {
            case 'A':
                {
                    currentScore += apple.getScore();
                    break;
                }
            case 'B':
                {
                    currentScore += banana.getScore();
                    break;
                }
            case 'C':
                {
                    currentScore += cherry.getScore();
                    break;
                }
            default:
                {
                    break;
                }

        }
        */


  



    public void SetScore(char item)
    {
        
        

        /*switch (item)
        {
            case 'A':
                {
                    //apple.points(minScore);
                  
                      break;
                }
            case 'B':
                {
                    //banana.points(minScore*1.25f);
                    break;
                }
            case 'S':
                {
                    //starberry.points(maxScore);
                    break;
                }
            default:
                {
                    break;
                }
        }*/
    }

    public void ItemDestroyed(PickUpItemControl  item)
    {

        items.Remove(item);

    }

    public void EnemyDestroyed(PickUpItemControl enemy)
    {

        //enemies.Remove(enemy);

        //AddScore(ScoreControl.currentScore);
        whatDestroyed = 2;
    }

    public void EggDestroyed(EggControl egg)
    {

        eggs.Remove(egg);

        //AddScore(ScoreControl.currentScore);
        whatDestroyed = 1;

    }

    public void PlayerDestroyed(PenguinControl penguin)
    {

        player.Remove(penguin);

    }



    // Use this for initialization
    void Start () {
        theWorld = FindObjectOfType<WorldControl>();

        eggs = new List<EggControl>();
        items = new List<PickUpItemControl>();
        enemies = new List<NPCControl>();
        player = new List<PenguinControl>();


    }
	

    public void startOfWorld()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}

    
}
