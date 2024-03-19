using UnityEngine;
using UnityEngine.EventSystems;

public class WordSymbolSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropped");
        GameObject dropped = eventData.pointerDrag;
        DraggableItem item = dropped.GetComponent<DraggableItem>();
        if(item == null) return;

        item.Parent = transform;
    }
}
