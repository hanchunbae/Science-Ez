using UnityEngine;
using UnityEngine.EventSystems;

public class ChargePlacer : MonoBehaviour
{
    [Header("설정")]
    public Camera mainCamera;
    public GameObject positiveChargePrefab;
    public GameObject negativeChargePrefab;

    private GameObject preview;       // 마우스 따라다니는 미리보기
    private GameObject prefabToPlace; // 선택된 프리팹

    void Update()
    {
        if (preview == null) return;

        // 마우스 위치 → 월드 좌표
        Vector3 mouseWorld = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0;
        preview.transform.position = mouseWorld;

        // 좌클릭 → 배치
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            PlaceCharge(mouseWorld);

        // 우클릭 → 취소
        if (Input.GetMouseButtonDown(1))
            CancelPlacement();
    }

    // UI 버튼 호출
    public void SelectPositiveCharge() => StartPlacement(positiveChargePrefab);
    public void SelectNegativeCharge() => StartPlacement(negativeChargePrefab);

    private void StartPlacement(GameObject prefab)
    {
        prefabToPlace = prefab;

        if (preview != null) Destroy(preview);

        preview = Instantiate(prefabToPlace);
        SetPreviewMode(preview, true);
    }

    private void PlaceCharge(Vector3 pos)
    {
        // 실제 오브젝트 생성
        GameObject placed = Instantiate(prefabToPlace, pos, Quaternion.identity);
        SetPreviewMode(placed, false); // 프리뷰 모드 해제 → 실제 오브젝트

        // 프리뷰 제거
        Destroy(preview);
        preview = null;
        prefabToPlace = null;
    }

    private void CancelPlacement()
    {
        if (preview != null) Destroy(preview);
        preview = null;
        prefabToPlace = null;
    }

    private void SetPreviewMode(GameObject obj, bool isPreview)
    {
        Collider2D col = obj.GetComponent<Collider2D>();
        if (col != null) col.enabled = !isPreview;

        SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            Color c = sr.color;
            c.a = isPreview ? 0.5f : 1f;
            sr.color = c;
        }
    }
}
