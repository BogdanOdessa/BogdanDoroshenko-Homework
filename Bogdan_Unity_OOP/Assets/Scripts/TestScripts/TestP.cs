using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class TestP : MonoBehaviour
    {
        private void Start()
        {
            var example = FindObjectOfType<PredicateAndFuncDelegatesExample>();
            example.Predicate = collision => collision.gameObject.CompareTag("Player");
            const float damage = 50;
            example.Func = f => f - damage;
        Debug.Log(example);
        }
    }

