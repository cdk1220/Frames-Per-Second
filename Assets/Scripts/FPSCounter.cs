using UnityEngine;

public class FPSCounter : MonoBehaviour {

    // private set and public get
    public int AverageFPS { get; private set; }
    public int HighestFPS { get; private set; }
    public int LowestFPS { get; private set; }

    // Number of frames to average the frame rate over
    public int frameRange = 60;

    // Buffer for store the frame rate values for the desired number of frames
    int[] fpsBuffer;

    // Use to index into the buffer
    int fpsBufferIndex;


    void Update() {

        // Initialize if have to
        if (fpsBuffer == null || fpsBuffer.Length != frameRange) {
            InitializeBuffer();
        }
        UpdateBuffer();
        CalculateFPS();
    }

    // Used to initialize the frame rate buffer
    void InitializeBuffer()
    {
        // Make sure frame range is at least one
        if (frameRange <= 0) {
            frameRange = 1;
        }

        fpsBuffer = new int[frameRange];
        fpsBufferIndex = 0;
    }

    void UpdateBuffer() {

        /* Update happens every frame. So the calculation that is done here refelcts
        * the frame rate as of last frame in the current. */
        fpsBuffer[fpsBufferIndex++] = (int)(1f / Time.unscaledDeltaTime);

        // Wrapping the index back to the start
        if (fpsBufferIndex >= frameRange) {
            fpsBufferIndex = 0;
        }
    }

    void CalculateFPS() {
        int sum = 0;
        int highest = 0;
        int lowest = int.MaxValue;

        for (int i = 0; i < frameRange; i++) {
            int fps = fpsBuffer[i];
            sum += fps;

            if (fps > highest) {
                highest = fps;
            }

            if (fps < lowest) {
                lowest = fps;
            }
        }

        AverageFPS = sum / frameRange;
        HighestFPS = highest;
        LowestFPS = lowest;
    }
}
