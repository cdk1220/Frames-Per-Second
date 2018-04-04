using UnityEngine;

public class FPSCounter : MonoBehaviour {

    // private set and public get
    public int FPS { get; private set; }


    void Update() {
        
        /* Update happens every frame. So the calculation that is done here refelcts
         * the frame rate as of last frame in the current. */
        FPS = (int)(1f / Time.unscaledDeltaTime);
    }
}
