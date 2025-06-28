using UnityEngine;

public class WorldFlip : MonoBehaviour
{
    [Header("World Objects")]
    public GameObject lightWorld;
    public GameObject shadowWorld;
    public Transform player;

    private Vector3 lightWorldPosition;
    private Vector3 shadowWorldPosition;

    public static bool inShadow = false;

    void Start()
    {
        // Set both world positions to the starting position of the player
        lightWorldPosition = player.position;
        shadowWorldPosition = player.position;
        inShadow = false;

        // Ensure proper world state
        lightWorld.SetActive(true);
        shadowWorld.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            FlipWorld();
        }
    }

    void FlipWorld()
    {
        // Save current position into the correct world
        if (inShadow)
        {
            shadowWorldPosition = player.position;
        }
        else
        {
            lightWorldPosition = player.position;
        }

        // Flip world state
        inShadow = !inShadow;

        // Toggle visibility of worlds
        lightWorld.SetActive(!inShadow);
        shadowWorld.SetActive(inShadow);

        // Move player to saved position in new world
        if (inShadow)
        {
            player.position = shadowWorldPosition;
        }
        else
        {
            player.position = lightWorldPosition;
        }

        Debug.Log("World flipped. In shadow world: " + inShadow);
    }
}
