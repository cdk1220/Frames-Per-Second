# Frames Per Second (Catlike Coding)

This project was completed by following "Frames Per Second" tutorial on 
http://catlikecoding.com/unity/tutorials/frames-per-second/.

## Lessons Learned

### Main Lessons
- How measure frame rate
- How to stabilize the frame rate by averaging multiple frames

### Programming in C#
- How to use "RequireComponent" property
- That class fields and methods are private by default
- How to make a field private set and public get
- How to prevent the creation of temporary strings

### About MonoBehaviour
- That "FixedUpdate" has to be used to change objects that have anything to do with physics
- That "Update" only gets called once every frame and "FixedUpdate" gets called as many times
  as needed to make physics related activities frame rate independent
- That "Time.deltaTime" to has to be called to make the motion of objects per second instead of per
  frame
- Difference between "Time.deltaTime" and "Time.unscaledDeltaTime"

### About the Unity Editor
- How to use properties of "TimeManager" in "Edit / Project Settings / Time" work
- How to enable and disable "vsync"
- That the Unity editor interferes the measurements in Profiler
- That a standalone build attached to the Profiler will not let the editor interfere
- Usage of UI elements such as Canvases, Panels, and Texts
   