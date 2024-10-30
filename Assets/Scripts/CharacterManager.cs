using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    
    public static CharacterManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance= new GameObject("CharacterManager").AddComponent<CharacterManager>();
            }
            return instance;
        }
    }

    public Player player;

    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;  
            DontDestroyOnLoad(gameObject);
        }
    }
}
