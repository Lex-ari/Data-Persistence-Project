using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{

    public static DataManager Instance;

    public string username;

	public string highUsername;
    public int highScore;

	private void Awake() {
		if (Instance != null) {
			Destroy(gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}

	[System.Serializable]
	class SaveData {
		public string username;
		public int highScore;
	}

	public void saveHighScore() {
		SaveData data = new SaveData();
		data.highScore = highScore;
		data.username = username;
		string json = JsonUtility.ToJson(data);
		File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
	}

	public void loadHighScore() {
		string path = Application.persistentDataPath + "/savefile.json";
		if (File.Exists(path)) {
			string json = File.ReadAllText(path);
			SaveData data = JsonUtility.FromJson<SaveData>(json);
			highUsername = data.username;
			highScore = data.highScore;
		}
	}
}
