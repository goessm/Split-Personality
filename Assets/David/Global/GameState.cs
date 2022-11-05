using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public enum GameItem {
        Zeitung = 0,
        Poop = 1,
    }
    public static bool monokel;
    public static Dictionary<GameItem, bool> items = new Dictionary<GameItem, bool>();
    public static Dictionary<string, int> NPCConversationIndexes = new Dictionary<string, int>();

}
