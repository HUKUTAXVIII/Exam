using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteLib;

namespace NoteLibTest
{
    [TestClass]
    public class NoteManagerTest
    {
        [TestMethod]
        public void TestSaveNotes()
        {
            NoteManager manager = new NoteManager();

            Assert.IsFalse(manager.SaveNotes("C:/"));

            manager.Notes.Add(new Note("test","test",DateTime.Now));
            Assert.IsTrue(manager.SaveNotes("C:/"));

            Assert.IsTrue(Directory.Exists("C:/Notes"));

        }

        [TestMethod]
        public void TestLoadNotes() {
            NoteManager manager = new NoteManager();

            Assert.IsTrue(manager.LoadNotes("C:/"));
            Assert.IsTrue(manager.Notes.Count > 0);
        }
        
    }
}
