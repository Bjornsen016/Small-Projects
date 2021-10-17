using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Notes
{
    public class Notes
    {
        public List<string> NoteList = new();
        private readonly string _path;

        public Notes()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            _path = Path.Combine(_path, "Notes.txt");
            Load();
        }

        public void CreateNote(string note)
        {
            NoteList.Add(note);
        }

        public void Load()
        {
            if (File.Exists(_path))
            {
                using var sr = new StreamReader(_path);
                string notes = sr.ReadToEnd();
                NoteList = JsonSerializer.Deserialize<List<string>>(notes);
            }
            else NoteList.Clear();
        }

        public void Save()
        {
            using var sr = new StreamWriter(_path);
            sr.Write(JsonSerializer.Serialize(NoteList));
        }

    }
}