// データベースの管理

using UnityEngine;
using System.Collections;

public class DatabaseManager : Singleton<DatabaseManager>
{
    public string databaseName = "HetApp.db";
    private SqliteDatabase database;

    private void Start()
    {
        database = new SqliteDatabase(databaseName);
    }

    public DataTable ExecuteQuery(string query)
    {
        Debug.Log("ExecuteQuery : " + query);
        return database.ExecuteQuery(query);
    }
}
