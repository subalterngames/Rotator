using UnityEngine;
using System.Collections;


namespace SubalternGames
{
    /// <summary>
    /// Example code for how to use Rotator.cs
    /// </summary>
    public class RotatorExample : MonoBehaviour
    {
        /// <summary>
        /// Rotate by this angle per frame.
        /// </summary>
        public float pitch = 0.5f;
        /// <summary>
        /// Roll by this angle per frame.
        /// </summary>
        public float roll = 1f;


        private void Start()
        {
            // Start the rotation example.
            StartCoroutine(Rotate());
        }


        /// <summary>
        /// Rotate the object.
        /// </summary>
        private IEnumerator Rotate()
        {
            // Rotate the transform by a little bit per frame.
            for (int i = 0; i < 200; i++)
            {
                // Apply the pitch angle.
                transform.PitchBy(pitch);

                // Apply the roll angle.
                transform.RollBy(roll);

                yield return new WaitForEndOfFrame();
            }
        }
    }
}