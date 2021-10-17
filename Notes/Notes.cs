using System;
using System.Collections.Generic;
using System.IO;

namespace Notes
{
    public class Notes
    {
        public readonly List<string> NoteList = new();
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

                var line = sr.ReadLine();
                while (line != null)
                {
                    NoteList.Add(line);

                    line = sr.ReadLine();
                }
            }
            else
            {
                NoteList.Clear();
            }
        }

        public void Save()
        {
            using var sr = new StreamWriter(_path);

            foreach (var str in NoteList)
            {
                sr.WriteLine(str);
            }
        }

    }
}