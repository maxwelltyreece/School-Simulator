//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Xml;
//using System.Xml.Serialization;
//using System.IO;

//public class SaveManagement : MonoBehaviour
//{
//    XmlSerializer sz = new XmlSerializer(typeof(SaveXml));
//    public void SaveGame(string saveFileLocation)
//    {
//        GameSave g = new GameSave();
//        g.CodeMissionCode();


//        FileStream fs = new FileStream(saveFileLocation, FileMode.Open);
//        XmlWriter writer = new XmlTextWriter();
//        sz.Serialize(writer, g);
//        writer.Close();
//    }

//    public void LoadGame(string saveFileLocation)
//    {
//        FileStream stream = new FileStream(saveFileLocation, FileMode.Open);
//        sz.Deserialize(stream);
//    }
//}

//public class GameSave
//{
//    public int money = PlayerPrefs.GetInt("MoneyCounter");
//    public int M1 = PlayerPrefs.GetInt("M1"),
//               M2 = PlayerPrefs.GetInt("M2"),
//               M3 = PlayerPrefs.GetInt("M3"),
//               M4 = PlayerPrefs.GetInt("M4"),
//               M5 = PlayerPrefs.GetInt("M5");
//    public int MissionCode;
//    public void CodeMissionCode()
//    {
//        MissionCode = int.Parse(M1.ToString() + M2.ToString() + M3.ToString() + M4.ToString() + M5.ToString());
//    }
//    public void DecodeMissionCode()
//    {
//        PlayerPrefs.SetInt("M1", MissionCode.ToString()[0]);
//        PlayerPrefs.SetInt("M2", MissionCode.ToString()[1]);
//        PlayerPrefs.SetInt("M3", MissionCode.ToString()[2]);
//        PlayerPrefs.SetInt("M4", MissionCode.ToString()[3]);
//        PlayerPrefs.SetInt("M5", MissionCode.ToString()[4]);

//    }
//}

//[XmlRoot(ElementName = "save")]
//public class SaveXml
//{
//    [XmlElement(ElementName = "money")]
//    public int money;

//    [XmlElement(ElementName = "misionCode")]
//    public int missionCode;
//}
