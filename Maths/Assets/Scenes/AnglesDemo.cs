﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglesDemo : MonoBehaviour {

    private void Start()
    {
        {
            // BEGIN angles
            // In Unity, most rotations that are represented as Euler
            // angles are done as degrees. As a refresher, there are 360
            // degrees in a circle.

            // BEGIN angles1
            // Rotate 90 degrees - one quarter circle - around the X axis
            transform.Rotate(90, 0, 0);             
            // END angles1

            // However, several math functions work in radians. There are
            // 2π radians in a circle.

            // BEGIN angles2
            // The sine of pi radians (one half-circle) is zero
            Mathf.Sin(Mathf.PI);  // = 0
            // END angles2

            // Degrees are a little more familiar to most people, but
            // radians are easier for calculations to work in. For this
            // reason, most of the Mathf functions in Unity that deal with
            // angles work in radians.

            // You can convert from radians to degrees, and back again:

            // BEGIN angles3
            // Converting 90 degrees to radians
            var radians = 90 * Mathf.Deg2Rad; // ~= 1.57 (π / 2)

            // Converting 2π radians to degrees
            var degrees = 2 * Mathf.PI * Mathf.Rad2Deg; // = 360
            // END angles3

            // The dot product of two unit vectors is equal to the cosine
            // of the angle between them.

            // If you have the cosine of a degree, you can get the original
            // degree by taking the arc cosine of it.

            // This means that you can find the angle between two vectors
            // like this:

            // BEGIN angles4
            var angle = Mathf.Acos(Vector3.Dot(Vector3.up, Vector3.left));
            // END angles4
            // = π radians; convert it to degrees if you want to show that
            // to the user


            // END angles


        }
    }

}
