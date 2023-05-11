using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class iconSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMouseOverUI())
        {
            GameObject characterSelected = MouseOverCharacterFrame();
            if(characterSelected != null && Input.GetMouseButtonDown(0))
            {
                //characterSelected.transform.Find("select").GetComponent<Image>().enabled = true;
                Debug.Log("Hover Something");
            }
        }
    }

    void OnMouseOver()
    {
        //this.transform.Find("select").GetComponent<Image>().enabled = true;
        Debug.Log("Hover Something");
    }

    private void OnMouseExit()
    {
       // this.transform.Find("select").GetComponent<Image>().enabled = false;
    }
    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    private GameObject MouseOverCharacterFrame()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> raycastResultList = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, raycastResultList);

        GameObject selectedCharacter = null;

        for (int i = 0; i < raycastResultList.Count; i++)
        {
            if (raycastResultList[i].gameObject.GetComponent<iconSelect>())
            {
                selectedCharacter = raycastResultList[i].gameObject;
                Debug.Log(gameObject.name);
                return selectedCharacter;

            }
        }

        return selectedCharacter;
    }
}
