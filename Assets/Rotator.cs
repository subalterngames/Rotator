using UnityEngine;
using System.Collections.Generic;


namespace SubalternGames
{
    /// <summary>
    /// Rotate a quaternion or object by an angle around an axis.
    /// </summary>
    public static class Rotator
    {
        /// <summary>
        /// An axis of rotation.
        /// </summary>
        private enum Axis
        {
            /// <summary>
            /// Nod your head "yes".
            /// </summary>
            pitch,
            /// <summary>
            /// Shake your head "no".
            /// </summary>
            yaw,
            /// <summary>
            /// Put your ear to your shoulder.
            /// </summary>
            roll
        }


        /// <summary>
        /// Each axis of rotation as a direction in Unity worldspace.
        /// </summary>
        private static readonly Dictionary<Axis, Vector3> Axes = new Dictionary<Axis, Vector3>
        {
            { Axis.roll, Vector3.forward },
            { Axis.yaw, Vector3.up },
            { Axis.pitch, Vector3.right }
        };


        /// <summary>
        /// Pitch (nod your head "yes") by an angle.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="angle">The angle of rotation in degrees.</param>
        public static void PitchBy(this Transform transform, float angle)
        {
            transform.RotateBy(angle, Axis.pitch);
        }


        /// <summary>
        /// Roll (put your ear to your shoulder) by an angle.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="angle">The angle of rotation in degrees.</param>
        public static void RollBy(this Transform transform, float angle)
        {
            transform.RotateBy(angle, Axis.roll);
        }


        /// <summary>
        /// Yaw (shake your head "no") by an angle.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="angle">The angle of rotation in degrees.</param>
        public static void YawBy(this Transform transform, float angle)
        {
            transform.RotateBy(angle, Axis.yaw);
        }


        /// <summary>
        /// Rotate by an angle around an axis. Returns the new quaternion.
        /// </summary>
        /// <param name="axis">The axis being rotated around.</param>
        /// <param name="angle">The angle of rotation in degrees.</param>
        /// <param name="quaternion">The quaternion.</param>
        private static Quaternion RotateBy(this Quaternion quaternion, float angle, Axis axis)
        {
            return quaternion * Quaternion.AngleAxis(angle, Axes[axis]);
        }


        /// <summary>
        /// Rotate an object by a given angle around a given axis.
        /// </summary>
        /// <param name="angle">The angle of rotation.</param>
        /// <param name="axis">The axis around which the object is rotated.</param>
        /// <param name="isWorld">If true, the object will rotate via "global" directions and angles. If false, the object will rotate with respect to its current rotation.</param>
        private static void RotateBy(this Transform transform, float angle, Axis axis, bool isWorld = true)
        {
            if (isWorld)
            {
                transform.localRotation =
                    Quaternion.identity.RotateBy(angle, axis) *
                    transform.localRotation;
            }
            else
            {
                transform.localRotation = transform.localRotation.RotateBy(angle, axis);
            }
        }
    }
}