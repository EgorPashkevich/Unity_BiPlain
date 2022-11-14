using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorGold : MonoBehaviour
{
    public GameObject GoldPrefab;
    public float SecondsCreateGold;
    
    public List<int> _listNumbers;

    private void Awake() {
        _listNumbers = StaticreatList.RR_3(-40, 40, 5);
    }
    void Start()
    {
        StartCoroutine(createGold());
    }
    IEnumerator createGold() {
        while(true){
            Instantiate(GoldPrefab,new Vector3(0, _listNumbers[Random.Range(3, 12)], _listNumbers[Random.Range(0, _listNumbers.Count)]), Quaternion.identity);
            yield return new WaitForSeconds(SecondsCreateGold);
        }
    }
}
