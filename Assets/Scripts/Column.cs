﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Manuk>() != null)
        {
            GameController.instance.BirdScored();
        }
    }
}