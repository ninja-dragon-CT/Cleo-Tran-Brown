using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();
    }

    public void searchDialog()
    {
        if (clue == 0)
        {
            dialog = "Im sad! I wont be able to watch my film, can you help?";
        }

        if (clue == 1)
        {
            dialog = "Oh No! my balloons flew away. Can you help get it back?";
        }

        if (clue == 2)
        {
            dialog = "HELP! IM DROWNING GIVE ME MY LIFE SAVER!";
        }

        if (clue == 3)
        {
            dialog = "My Bull's Eye broke can you get me one?";
        }


        if (clue == 4)
        {
            dialog = "HELP! One of the pipes broke and waters flooding out, Please help us.";
        }

        if (clue == 5)
        {
            dialog = "Hi! I lost my keys to my little dirt shack, can you help?";
        }

        if (clue == 6)
        {
            dialog = "Im HANGRY GIMME SOME FISH!";
        }

        if (clue == 7)
        {
            dialog = "My bird is dying from cold, I want a bird house.";
        }

        if (clue == 8)
        {
            dialog = "I need to prank my friend! do you have a red air horn?";
        }

        if (clue == 9)
        {
            dialog = "Im a magician and lost my hat, can you help?";
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You found my " + collectibles[clue] + "! Horray!";
            end = true;
        }
        else
        {
            dialog = "No, thats not my " + collectibles[clue] + ",";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
