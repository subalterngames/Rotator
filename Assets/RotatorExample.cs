using UnityEngine;
using System.Collections;
using SubalternGames;


/// <summary>
/// Example code for how to use the Rotator class.
/// Apply a rotation first to an object using discrete angles,
/// then to a quaternion using a lerp,
/// and finally to a rigidbody.
/// </summary>
public class RotatorExample : MonoBehaviour
{
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
            transform.Pitch(0.5f);

            // Apply the roll angle.
            transform.Roll(1f);

            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);

        // Reset the rotation.
        transform.rotation = Quaternion.identity;

        // Apply a lerp.
        Quaternion rotated = transform.rotation;
        rotated = rotated.Pitch(90).Yaw(45);
        
        while (Quaternion.Angle(transform.rotation, rotated) > 0.1f)
        {
            // Apply the lerp.
            transform.rotation = Quaternion.Lerp(
                transform.rotation, rotated, Time.deltaTime);

            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);

        // Reset the rotation.
        transform.rotation = Quaternion.identity;

        // Add the rigidbody.
        Rigidbody r = gameObject.AddComponent<Rigidbody>();
        r.isKinematic = true;

        rotated = transform.rotation;
        rotated = rotated.Pitch(90).Yaw(45);

        // Apply a lerp on the rigidbody using the physics-safed MoveRotation method.
        while (Quaternion.Angle(transform.rotation, rotated) > 0.1f)
        {
            r.MoveRotation(Quaternion.Lerp(
                transform.rotation, rotated, Time.deltaTime));

            yield return new WaitForEndOfFrame();
        }
    }
}