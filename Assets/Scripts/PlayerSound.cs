using UnityEngine;
using UnityEngine.Rendering;

public class PlayerSound : MonoBehaviour
{
    private Player player;
    private float footstepTimer;
    private float footstepTimeMax=.1f;


    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        footstepTimer -= Time.deltaTime;
        if (footstepTimer < 0)
        {
            footstepTimer = footstepTimeMax;
            if (player.IsWalking())
            {
                float volume =1;
                SoundManager.Instance.PlayFootstepsSound(volume);
            }          
        }
    }
}
