using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DebugDrawUility
{

    public static void Cartesian(Transform transform, float lenght = 1, Space type = Space.Self, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        Cartesian(transform.position, transform.rotation, lenght, type, duration);
    }
    public static void Cartesian(Vector3 position, Quaternion rotation, float lenght = 1, Space type = Space.Self, float duration=0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        if (type == Space.Self) {
            Debug.DrawLine(position, position + (rotation * Vector3.forward) * lenght, Color.blue, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.right) * lenght, Color.red, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.up) * lenght, Color.green, duration);
        }
        else
        {
            Debug.DrawLine(position, position + Vector3.forward * lenght, Color.blue, duration);
            Debug.DrawLine(position, position + Vector3.right * lenght, Color.red, duration);
            Debug.DrawLine(position, position + Vector3.up * lenght, Color.green, duration);
        }
    }


    public static void CartersianCross(
        Transform transform,
        float radiusPositive = 1,
        float radiusNegative = 0.1f,
        Space type = Space.Self,
        float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        CartersianCross(transform.position, transform.rotation,
            radiusPositive, radiusNegative, type, duration);
    }

    public static void CartersianCross(
        Vector3 position,
        Quaternion rotation,
        float radiusPositive = 1,
        float radiusNegative = 0.1f,
        Space type = Space.Self, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        if (type == Space.Self)
        {

            Debug.DrawLine(position, position + (rotation * Vector3.forward) * radiusPositive, Color.blue, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.right) * radiusPositive, Color.red, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.up) * radiusPositive, Color.green, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.back) * radiusNegative, Color.blue, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.left) * radiusNegative, Color.red, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.down) * radiusNegative, Color.green, duration);

        }
        else
        {
            Debug.DrawLine(position, position + Vector3.forward * radiusPositive, Color.blue, duration);
            Debug.DrawLine(position, position + Vector3.right * radiusPositive, Color.red, duration);
            Debug.DrawLine(position, position + Vector3.up * radiusPositive, Color.green, duration);
            Debug.DrawLine(position, position + Vector3.back * radiusNegative, Color.blue, duration);
            Debug.DrawLine(position, position + Vector3.left * radiusNegative, Color.red, duration);
            Debug.DrawLine(position, position + Vector3.down * radiusNegative, Color.green, duration);

        }
    }

    public static void Cross(Transform transform, Color color, float lenght = 1, Space type = Space.Self, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        Cross(transform.position, transform.rotation, color, lenght, type, duration);
    }
    public static void Cross(Vector3 position, Quaternion rotation, Color color, float lenght = 1, Space type = Space.Self, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        if (type == Space.Self)
        {
            Debug.DrawLine(position, position + (rotation * Vector3.forward) * lenght, color, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.right) * lenght, color, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.up) * lenght, color, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.back) * lenght, color, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.left) * lenght, color, duration);
            Debug.DrawLine(position, position + (rotation * Vector3.down) * lenght, color, duration);
        }
        else
        {
            Debug.DrawLine(position, position + Vector3.forward * lenght, color, duration);
            Debug.DrawLine(position, position + Vector3.right * lenght, color, duration);
            Debug.DrawLine(position, position + Vector3.up * lenght, color, duration);
            Debug.DrawLine(position, position + Vector3.back * lenght, color, duration);
            Debug.DrawLine(position, position + Vector3.left * lenght, color, duration);
            Debug.DrawLine(position, position + Vector3.down * lenght, color, duration);
        }
    }



    

    public static void LinePath(List<Transform> path, Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        LinePath(path.ToArray(), color, duration);
    }
    public static void LinePath(Transform[] path, Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        List<Vector3> points = new List<Vector3>();
        foreach (Transform point in path)
        {
            points.Add(point.position);
        }
        LinePath(points, color, duration);
    }
    public static void LinePath(List<Vector3> path, Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        if (path.Count <= 1) return;
        for (int i = 0; i < path.Count - 1; i++)
        {
            Debug.DrawLine(path[i], path[i + 1], color, duration);
        }
    }

    public static void CircularPath(List<Transform> path, Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        CircularPath(path.Select(k=>k.position).ToList(), color, duration);
    }

    public static void CircularPath(List<Vector3> path, Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);
        LinePath(path, color, duration);
        if ( path.Count>2)
        {
            Debug.DrawLine(path[0], path[path.Count - 1], color, duration);

        }
    }

    public static void SetToDeltaTimeIfUnderZero(ref float duration)
    {
        if (duration < 0)
        {
            duration = Time.deltaTime;
        }
    }

    public static void RayLine(Transform target, Vector3 axis, float radius, Space space, Color color)
    {
     
        RayLine(target.position, target.rotation, axis, radius, space, color);
    }

    public static void RayLine(Vector3 position, Quaternion rotation, Vector3 axis, float radius, Space space, Color color)
    {
        Vector3 point = position;
        if (space == Space.Self)
        {
            point += rotation * axis * radius;
        }
        else
        {
            point += axis * radius;
        }

        Debug.DrawLine(position, point, color);


    }

    public static void CameraView(Camera target, 
        Color colorNear, 
        Color colorLine,
        Color colorFar,
        float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);

        Vector3 [] nearView = new Vector3[4];
        nearView[0] = target.ViewportToWorldPoint(new Vector3(0, 0, target.nearClipPlane));
        nearView[1] = target.ViewportToWorldPoint(new Vector3(1, 0, target.nearClipPlane));
        nearView[2] = target.ViewportToWorldPoint(new Vector3(1, 1, target.nearClipPlane));
        nearView[3] = target.ViewportToWorldPoint(new Vector3(0, 1, target.nearClipPlane));
        Debug.DrawLine(nearView[0], nearView[1], colorNear, duration);
        Debug.DrawLine(nearView[1], nearView[2], colorNear, duration);
        Debug.DrawLine(nearView[2], nearView[3], colorNear, duration);
        Debug.DrawLine(nearView[3], nearView[0], colorNear, duration);

        Vector3[] farView = new Vector3[4];
        farView[0] = target.ViewportToWorldPoint(new Vector3(0, 0, target.farClipPlane));
        farView[1] = target.ViewportToWorldPoint(new Vector3(1, 0, target.farClipPlane));
        farView[2] = target.ViewportToWorldPoint(new Vector3(1, 1, target.farClipPlane));
        farView[3] = target.ViewportToWorldPoint(new Vector3(0, 1, target.farClipPlane));
        Debug.DrawLine(farView[0], farView[1], colorFar, duration);
        Debug.DrawLine(farView[1], farView[2], colorFar, duration);
        Debug.DrawLine(farView[2], farView[3], colorFar, duration);
        Debug.DrawLine(farView[3], farView[0], colorFar, duration);
        Debug.DrawLine(nearView[0], farView[0], colorLine, duration);
        Debug.DrawLine(nearView[1], farView[1], colorLine, duration);
        Debug.DrawLine(nearView[2], farView[2], colorLine, duration);
        Debug.DrawLine(nearView[3], farView[3], colorLine, duration);




    }

    public static void CenterToCorner(
        Transform center, 
        Transform corner, 
        Color color, float duration = 0)
    {
        SetToDeltaTimeIfUnderZero(ref duration);

        WorldToLocal(out Vector3 local, corner.position, center.rotation, center.position);

        Vector3[] corners = new Vector3[8];
        corners[0] = new Vector3(local.x, local.y, local.z);
        corners[1] = new Vector3(local.x, local.y, -local.z);
        corners[2] = new Vector3(local.x, -local.y, local.z);
        corners[3] = new Vector3(local.x, -local.y, -local.z);
        corners[4] = new Vector3(-local.x, local.y, local.z);
        corners[5] = new Vector3(-local.x, local.y, -local.z);
        corners[6] = new Vector3(-local.x, -local.y, local.z);
        corners[7] = new Vector3(-local.x, -local.y, -local.z);

        LocalToWorld(out Vector3 corner0, corners[0], center.rotation, center.position);
        LocalToWorld(out Vector3 corner1, corners[1], center.rotation, center.position);
        LocalToWorld(out Vector3 corner2, corners[2], center.rotation, center.position);
        LocalToWorld(out Vector3 corner3, corners[3], center.rotation, center.position);
        LocalToWorld(out Vector3 corner4, corners[4], center.rotation, center.position);
        LocalToWorld(out Vector3 corner5, corners[5], center.rotation, center.position);
        LocalToWorld(out Vector3 corner6, corners[6], center.rotation, center.position);
        LocalToWorld(out Vector3 corner7, corners[7], center.rotation, center.position);

        Debug.DrawLine(corner0, corner1, color, duration);
        Debug.DrawLine(corner1, corner3, color, duration);
        Debug.DrawLine(corner3, corner2, color, duration);
        Debug.DrawLine(corner2, corner0, color, duration);
        Debug.DrawLine(corner4, corner5, color, duration);
        Debug.DrawLine(corner5, corner7, color, duration);
        Debug.DrawLine(corner7, corner6, color, duration);
        Debug.DrawLine(corner6, corner4, color, duration);
        Debug.DrawLine(corner0, corner4, color, duration);
        Debug.DrawLine(corner1, corner5, color, duration);
        Debug.DrawLine(corner2, corner6, color, duration);
        Debug.DrawLine(corner3, corner7, color, duration);





    }

    private static void WorldToLocal( out Vector3 local, Vector3 world, Quaternion rotation, Vector3 position)
    {
        local = Quaternion.Inverse(rotation) * (world - position);
    }
    private static void LocalToWorld(out Vector3 world, Vector3 local, Quaternion rotation, Vector3 position)
    {
        world = rotation * local + position;
    }
}