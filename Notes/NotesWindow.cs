using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Notes
{
    public partial class NotesWindow : Form
    {
        private readonly Notes _notes;
        private bool _changingNote;

        public NotesWindow()
        {
            InitializeComponent();
            _changingNote = false;
            _notes = new Notes();
            RefreshDisplayedNotes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NoteBox.Text == "") return;

            if (_changingNote)
            {
                int index = ListBoxSavedNotes.SelectedIndex;
                _notes.NoteList[index] = NoteBox.Text;
                _changingNote = false;
            }
            else _notes.CreateNote(NoteBox.Text);

            NoteBox.Clear();
            _notes.Save();
            RefreshDisplayedNotes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxSavedNotes.SelectedIndex;
            _changingNote = false;
            if (index >= 0)
            {
                _notes.NoteList.RemoveAt(index);
                _notes.Save();
                RefreshDisplayedNotes();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxSavedNotes.SelectedIndex;
            if (_notes.NoteList.Count != 0)
            {
                NoteBox.Text = _notes.NoteList[index];
                _changingNote = true;
            }
        }

        private void RefreshDisplayedNotes()
        {
            List<string> content = _notes.NoteList.ToList();

            ListBoxSavedNotes.DataSource = content;
        }

        private void NoteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && ModifierKeys == Keys.Shift)
            {
                if (NoteBox.Text == "") return;

                if (_changingNote)
                {
                    int index = ListBoxSavedNotes.SelectedIndex;
                    _notes.NoteList[index] = NoteBox.Text;
                    _changingNote = false;
                }
                else _notes.CreateNote(NoteBox.Text);

                NoteBox.Clear();
                _notes.Save();
                RefreshDisplayedNotes();
            }
        }
    }
}