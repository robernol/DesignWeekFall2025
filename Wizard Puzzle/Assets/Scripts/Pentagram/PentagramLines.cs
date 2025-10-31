using UnityEngine;

public class PentagramLines : MonoBehaviour
{
    public LineRenderer lr;

    public void CreateLine(Vector3 start, Vector3 end)
    {
        lr.positionCount = 2;
        lr.SetPosition(0, new Vector3(start.x, start.y, -1));
        lr.SetPosition(1, new Vector3(end.x, end.y, -1));
    }
}
