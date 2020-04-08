using UnityEngine;

// 註解:用來說明紀錄等等....只會在此腳本看到
// 摘要 summary:描述此內容,會在其他腳本看到-提高維護性與擴充性
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員: 欄位 field- 儲存物件資料
    // 資料類型
    // cc數 - 2000 - 整數 int
    // 重量  - 100.9 -浮數點 float
    // 品牌 - BMW - 字串 string
    // 剎車 - 是否開啟 - 布林值 bool- true,false

    // 定義欄位語法 :
    // 資料類型 欄位名稱 (指定 值);
    // 預設值 
    // int float 為 0
    // string 為 ""
    // bool 為 false
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;
}
