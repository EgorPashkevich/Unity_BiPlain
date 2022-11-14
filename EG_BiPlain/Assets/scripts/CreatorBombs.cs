using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorBombs : MonoBehaviour
{
    public GameObject BombPrefab;
    public float SecondsCreateBomb;

    public List<int> _listNumbers;
    private void Awake() {
        _listNumbers = StaticreatList.RR_3(-45, 45, 7);
    }

    void Start()
    {
        StartCoroutine(createBomb());
    }
    IEnumerator createBomb() {
        while(true){
            Instantiate(BombPrefab,new Vector3(0, _listNumbers[Random.Range(3, 10)], _listNumbers[Random.Range(0, _listNumbers.Count)]), Quaternion.identity);
            yield return new WaitForSeconds(SecondsCreateBomb);
        }
    }
}
