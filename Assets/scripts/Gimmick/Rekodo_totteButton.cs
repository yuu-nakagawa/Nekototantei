using UnityEngine;

public class Rekodo_totteButton : MonoBehaviour
{
    //アイテムの表示・非表示
    public GameObject Rekodo_totte1;
    public GameObject Rekodo_totte;

    //レコードの取っ手１をタップしたら、レコードの取っ手１を非表示、レコードの取っ手を表示する
    //・タイミング：クリックしたとき
    //・処理：レコードの取っ手１を非表示
    //・処理：レコードの取っ手を表示する

    //・タイミング：クリックしたとき
    public void Onrekodo_totte()
    {
        //処理：レコードの取っ手１を非表示
        Rekodo_totte1.SetActive(false);
        //レコードの取っ手を表示する
        Rekodo_totte.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }    
}
