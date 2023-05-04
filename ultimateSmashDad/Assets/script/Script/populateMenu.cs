using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class populateMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Character> characters = new List<Character>();
    public GameObject CharacterCellPrefab;
    void Start()
    {
     foreach (Character character in characters)
     {
            SpawnCharacterCell(character);
     }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnCharacterCell(Character character)
    {
        Debug.Log(character.name);
        GameObject charCell = Instantiate(CharacterCellPrefab, transform);
        Image artwork = charCell.transform.Find("Panel").transform.Find("Portrait").GetComponent<Image>();

        TextMeshProUGUI name = charCell.transform.Find("Panel").transform.Find("NameBorder").GetComponentInChildren<TextMeshProUGUI>();

        artwork.sprite = character.characterSprite;
        name.text = character.name;
    }
}


